using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Utilities
{
	public class ImageManipulation
	{
		//byte[]
		public static byte[] GetPhoto(System.Windows.Forms.PictureBox pb)
		{
			MemoryStream ms = new MemoryStream();
			pb.Image.Save(ms, pb.Image.RawFormat);
			return ms.GetBuffer();
		}

		public static Image PutPhoto(byte[] photo)
		{
			MemoryStream ms = new MemoryStream(photo);
			return Image.FromStream(ms);

		}
	}
}
