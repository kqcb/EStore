using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.Control;

namespace EStore.Utils
{
    static class Common
    {
        public static void ChangeLanguage(string key, string value)
        {
            var xml = new XmlDocument();

            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement item in xml.DocumentElement)
            {
                if(item.Name == "appSettings")
                {
                    foreach (XmlNode item1 in item.ChildNodes)
                    {
                        if(item1.Attributes[0].Value.Equals(key))
                        {
                            item1.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");

            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            Application.Restart();
        }

        public static void ChangeContorl(ControlCollection controls, UserControl control)
        {

            controls.Clear();
            control.Focus();
            control.BringToFront();
            control.Dock = DockStyle.Fill;
            controls.Add(control);
        }

        public static void AddControl(ControlCollection controls, UserControl control)
        {
            control.Dock = DockStyle.Fill;

            controls.Add(control);

            if (controls.Count > 0)
            {
                var temp = controls[0];
                controls.SetChildIndex(controls[controls.Count - 1], 0);
                controls.Add(temp);
            }
        }

        public static void RemoveControl(ControlCollection controls)
        {
            if(controls.Count > 0) 
                controls.RemoveAt(0);
        }

        internal static void RemoveControl(ControlCollection controls, int index)
        {
            throw new NotImplementedException();
        }

        public static Image ToImage(byte[] bytes)
        {
            var memoryStream = new MemoryStream(bytes, 0, bytes.Length);
            memoryStream.Write(bytes, 0, bytes.Length);
            return Image.FromStream(memoryStream, true);
        }

        public static byte[] ToByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            byte[] bytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(bytes, 0, bytes.Length);

            return bytes;

        }
    }
}
