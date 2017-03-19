using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using SharpShell.Attributes;
using SharpShell.SharpThumbnailHandler;

namespace ThumbnailGen
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.FileExtension, ".mov")]
    public class ThumbnailGen : SharpThumbnailHandler
    {
        protected override Bitmap GetThumbnailImage(uint width)
        {
            return null;
        }
    }
}
