using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.ViewModels
{
    public class ListAlbumsViewModel
    {
       public List<Album> Albums { get; set; }
       public SelectList Genres { get; set; }
       public SelectList Artists { get; set; }
       public string id { get; set; } 
       public int genreID { get; set; }
       public int artistID { get; set; }

    }
}
