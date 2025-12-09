using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.ColorPaletteGenerator
{
    /// <summary>
    /// Query options for the Color Palette Generator API
    /// </summary>
    public class ColorPaletteGeneratorQueryOptions
    {
        /// <summary>
        /// The base color to generate the palette from (e.g., FF5733)
        /// Example: FF5733
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// The variation of the color palette (e.g., soft, hard, pastel, light, pale)
        /// Example: soft
        /// </summary>
        [JsonProperty("variation")]
        public string Variation { get; set; }
    }
}
