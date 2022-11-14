using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ScoreTruco.Models
{
    internal class AboutModel
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/lordkaps/ScoreTruco";
        public string Message => @"Este app é escrito em XAML e C# com Xamarin.Forms. Foi desenvolvivo por Augusto Santos com finalidade de testes com xamarin e estudos. Gostaria de ver o codigo? Clique no botão para acessar o link.";
    }
}
