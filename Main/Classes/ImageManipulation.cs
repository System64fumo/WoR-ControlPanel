using System;
using System.Drawing;
using System.Drawing.Imaging;

public class ImageManipulation
{
    #region Change image color
    public static Bitmap ToColorTone(Image image, Color color)
    {
        //creating a new bitmap image with selected color.
        float r = color.R / 255f;
        float g = color.G / 255f;
        float b = color.B / 255f;

        // Color Matrix
        ColorMatrix cm = new ColorMatrix(new float[][]
        {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
        });
        ImageAttributes ImAttribute = new ImageAttributes();
        ImAttribute.SetColorMatrix(cm);

        //Color Matrix on new bitmap image
        Point[] points =
        {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1)
        };
        Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

        Bitmap myBitmap = new Bitmap(image.Width, image.Height);
        using (Graphics graphics = Graphics.FromImage(myBitmap))
        {
            graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
        }
        return myBitmap;
    }
    #endregion

    #region Bitmap to Icon
    public static Icon CreateIcon(Bitmap Source)
    {
        Bitmap squareCanvas = (Bitmap)Source.GetThumbnailImage(128, 128, null, new IntPtr());
        Icon iconResult = Icon.FromHandle(squareCanvas.GetHicon());
        return iconResult;
    }
    #endregion

    #region Overlay images
    public static Image OverlayImage(Image Image1, Image Image2, int Offset1x = 0, int Offset1y = 0, int Offset2x = 0, int Offset2y = 0)
    {
        int LargestWidth = (Image1.Width > Image2.Width) ? Image1.Width : Image2.Width;
        int LargestHeight = (Image1.Height > Image2.Height) ? Image1.Height : Image2.Height;
        Image image = new Bitmap(LargestWidth, LargestHeight);
        using (Graphics gr = Graphics.FromImage(image))
        {
            gr.DrawImage(Image1, new Point(Offset1x, Offset1y));
            gr.DrawImage(Image2, new Point(Offset2x, Offset2y));
        }
        return image;
    }
    #endregion

    #region Invert image color
    public static Image InvertColor(Image Source)
    {
        Bitmap bmpDest = new Bitmap(Source.Width, Source.Height);

        ColorMatrix clrMatrix = new ColorMatrix(new float[][]
        {
            new float[] {-1, 0, 0, 0, 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {0, 0, -1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {1, 1, 1, 0, 1}
        });

        using (ImageAttributes attrImage = new ImageAttributes())
        {
            attrImage.SetColorMatrix(clrMatrix);

            using (Graphics g = Graphics.FromImage(bmpDest))
            {
                g.DrawImage(Source, new Rectangle(0, 0,
                Source.Width, Source.Height), 0, 0,
                Source.Width, Source.Height, GraphicsUnit.Pixel,
                attrImage);
            }
        }
        return bmpDest;
    }
    #endregion
}
