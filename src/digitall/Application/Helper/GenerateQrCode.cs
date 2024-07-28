using System.Drawing.Imaging;
using QRCoder;
using SixLabors.ImageSharp.Formats.Qoi;

namespace Application.Helper;

public static class GenerateQrCode
{
    public static async Task<byte[]> GetQrCodeAsync(string text)
    {
        try
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(20);

            // Return image as byte array
            return qrCodeImage;
        }
        catch (System.Exception qr)
        {
            throw new ApplicationException("qr" + qr.Message);
        }
    }
}
