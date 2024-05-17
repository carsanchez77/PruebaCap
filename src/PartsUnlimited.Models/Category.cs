// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//Este comentario es para la linea 6
//Este es para la linea 7
namespace PartsUnlimited.Models
{
    public class Category //Local// //Nube//
<<<<<<< HEAD
    //se crea el conflicto
=======
    
>>>>>>> 5c22046c574d2049f96b4f3d709fa1a27591faa4
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
