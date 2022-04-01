using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Diagnostics;
using System.Windows.Forms;

namespace ManageDocu
{
    public class Model
    {
        public string[] LoadMyDrives() //kilistázza a meghajtóimat, mint egy string tömb
        {
            DriveInfo[] tmp = DriveInfo.GetDrives(); //lekéri egy tmp-be a meghajtókat
            List<string> drivesList = new List<string>();
            foreach (DriveInfo drive in tmp) //mennyi meghajtó van a tmp-be
            {
                if (drive.IsReady)
                {
                    drivesList.Add(drive.ToString()); //stringként adja vissza a meghajtó nevét!
                }
            }
            return drivesList.ToArray(); //visszatérés: tömb
        } 

        public string[] LoadDriveFiles(string path) //A meghajtó fájljait vagy mappáit listázza ki
        {
            try
            {
                FileAttributes attr = (new FileInfo(path)).Attributes; //FileInfo felel a path-ért
                Console.Write(attr); //Outputra kiírom ellenőrizni
                List<string> items = new List<string>();
                if (Directory.Exists(path)) 
                {
                    items.AddRange(Directory.GetDirectories(path)); //listába tartoznak a mappák
                    items.AddRange(Directory.GetFiles(path)); //és a fájlok
                }
                return ListToSend(items.ToArray()); //tömbbe a fájlok
            }
            catch (Exception) //Valami oknál fogva nem elérhető a fájl
            {
                FileAttributes attr = (new FileInfo(path)).Attributes;
                Console.Write("Can't acces this file");
                Console.WriteLine(attr);

                return null;

            }
        }
        private string dirID = "<dir> "; //mappa identifikálása
        private bool isDir(string pathtocheck) //eldönti, hogy mappa-e?
        {
            FileAttributes attr = File.GetAttributes(pathtocheck);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                return true;
            }

            return false;
        }
        private string[] ListToSend(string[] list) //megjelenítésért felel
        {
            List<string> ListToSend = new List<string>();
            foreach (string file in list)
            {
                string tmp = Directory.GetParent(file).ToString(); //parent mint string

                if (isDir(file))
                {
                    if (tmp.Length <=3) //karakterlánc hossza
                    {
                        ListToSend.Add(file.Replace(tmp, dirID)); //Old value, New Value, D, C meghajtó
                    }
                    else
                    {
                        ListToSend.Add(file.Replace(tmp + "\\", dirID)); //minden más
                    }
                }
                else
                {
                    if (tmp.Length <=3)
                    {
                        ListToSend.Add(file.Replace(tmp, "")); //lecsípjük az elejét, ha nem dir
                    }

                    else
                    {
                        ListToSend.Add(file.Replace(tmp + "\\", "")); //azért kell 2 \\ mert a visual studio miatt
                    }
                }

                
            }
            return ListToSend.ToArray();
        }

        public string GetParent(string path) 
        {
            Console.WriteLine(Directory.GetParent(path).ToString());
            if (Directory.Exists(path))
            {
                return Directory.GetParent(path).ToString();
            }
            return path;
        }

        public void PerformOperation(string source, string target, string item, string operation) 
        {
            Console.WriteLine(source);
            string itempath = CombineItemWithPath(item, source); //csak akkor lehet 1 methodra írni a gombokat, ha összevonjuk az itemeket a szülőkkel
            if (operation == "Delete")
            {
                if (Directory.Exists(source))
                {
                    if (isDir(itempath))
                    {
                        Directory.Delete(itempath, true);
                    }
                    else
                    {
                        if (File.Exists(itempath))
                        {
                            File.Delete(itempath);
                        }
                    }
                }
            }
            else if (operation == "Move")
            {
                if (Directory.Exists(itempath) && isDir(itempath)) //ez a feltétel kétszer volt megadva
                {
                    if (Directory.GetDirectoryRoot(itempath) == Directory.GetDirectoryRoot(target))
                    {
                        Directory.Move(itempath, CombineItemWithPath(item, target));
                    }
                    else
                    {
                        CopyDir(itempath, CombineItemWithPath(item, target));
                        Directory.Delete(itempath);
                    }
                }
                else
                {
                    if (File.Exists(itempath))
                    {
                        File.Move(itempath, CombineItemWithPath(item, target));
                    }
                }

            }
            else if (operation == "Copy") // operation változóba a button text kerül, melynek értéke "Copy " volt, "Copy" helyett. Ilyen esetben én beiktatnék egy bool változót, mely értékét vizsgáld a button properties text value helyett. Ez kizárja a jelen helyzetben fellépő elírásból adódó problémát.
            {
                if (System.IO.Directory.Exists(itempath) && isDir(itempath))
                {
                    MessageBox.Show(itempath);
                    CopyDir(itempath, CombineItemWithPath(item, target));
                }
                else
                {
                    if (System.IO.File.Exists(itempath))
                        System.IO.File.Copy(itempath, CombineItemWithPath(item, target));
                }
            }
        }

        private string CombineItemWithPath(string item, string path)
        {
            string trimmedItem = item.Replace(dirID, "");
            if (item.Contains(dirID))
            {
                if (path.EndsWith("\\"))
                {
                    return path + trimmedItem;

                }
                else
                    return path + "\\" + trimmedItem;
            }
            else
            {
                if (path.EndsWith("\\"))
                {
                    return path + item;
                }
                else
                {
                    return path + "\\" + item;
                }
            }
        }
        private void CopyDir(string source, string target) 
        {
            DirectoryInfo info = new DirectoryInfo(source);

            DirectoryInfo[] directories = info.GetDirectories();
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            FileInfo[] files = info.GetFiles();

            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(target, file.Name), true);
            }
            foreach (DirectoryInfo dir in directories) 
            {
                CopyDir(dir.FullName, Path.Combine(target, dir.Name));
            }
        }

        public string CheckItem(string item, string currentpath) //Kiválasztani a mappát/fájlt és megnyitni
        {
            string toreplace = dirID;
            if (item.Contains(toreplace))
            {
                if (hasPermission(CombineItemWithPath(item, currentpath), FileSystemRights.ListDirectory) && hasAccessToRead(CombineItemWithPath(item, currentpath)))
                {
                    if (currentpath.EndsWith("\\")) // az idézőjelek között // volt \\ helyett
                    {
                        return currentpath + item.Replace(toreplace, "");
                    }
                    else
                    {
                        return currentpath + "\\" + item.Replace(toreplace, "");
                    }
                }
                else
                {
                    return currentpath;
                }
            }
            else
            {
                openFile(currentpath + "\\" + item);
                return currentpath;
            }
        }

        private bool hasPermission(string path, FileSystemRights accessRight) 
        {
            try
            {
                AuthorizationRuleCollection rules = Directory.GetAccessControl(path).GetAccessRules(true, true, typeof(SecurityIdentifier));
                WindowsIdentity identity = WindowsIdentity.GetCurrent(); //jelenlegi Windows felhasználó

                foreach (FileSystemAccessRule rule in rules)
                {
                    if (identity.Groups.Contains(rule.IdentityReference))
                    {
                        if ((accessRight & rule.FileSystemRights) == accessRight)
                        {
                            if (rule.AccessControlType == AccessControlType.Allow)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        private bool hasAccessToRead(string path) 
        {
            FileAttributes attr = File.GetAttributes(path);
            if (!attr.HasFlag(FileAttributes.Hidden))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void openFile(string path) //Fájl megnyitása
        {
            if (File.Exists(path))
            {
                Process.Start(path);
            }
        }
    }
}
