using System;
using System.Drawing;
using Microsoft.AspNetCore.Http;

namespace TopLearn.Core.Security;

public static class ImageValidator
{
    public static bool IsImage(this IFormFile file)
    {
        try
        {
            var img = Image.FromStream(file.OpenReadStream());
            return true;
        }
        catch
        {
            return false;
        }
    }
}