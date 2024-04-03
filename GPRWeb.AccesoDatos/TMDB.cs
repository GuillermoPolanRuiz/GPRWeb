using GPRWeb.Modelos.Movie;
using GPRWeb.Modelos.TMDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.AccesoDatos
{
    public class TMDB
    {
        private readonly HttpClient _httpClient;

        public TMDB()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Movie>> GetMovieByName(string name)
        {
            try
            {
                string url = GetUrlByName(name);
                // Realizar la solicitud HTTP GET
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                response.EnsureSuccessStatusCode();

                // Leer el contenido JSON
                string json = await response.Content.ReadAsStringAsync();

                // Deserializar el JSON en una lista de objetos de clase Pelicula
                List<Movie> peliculas = JsonConvert.DeserializeObject<List<Movie>>(json);

                return peliculas;
            }
            catch (Exception ex)
            {
                // Manejar errores de manera adecuada según tus necesidades
                Console.WriteLine($"Error al obtener películas: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Movie>> GetTrending()
        {
            try
            {
                // Realizar la solicitud HTTP GET
                HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl.GetTrending);

                // Verificar si la solicitud fue exitosa
                response.EnsureSuccessStatusCode();

                // Leer el contenido JSON
                string json = await response.Content.ReadAsStringAsync();

                // Deserializar el JSON en una lista de objetos de clase Pelicula
                List<Movie> peliculas = JsonConvert.DeserializeObject<List<Movie>>(json);

                return peliculas;
            }
            catch (Exception ex)
            {
                // Manejar errores de manera adecuada según tus necesidades
                Console.WriteLine($"Error al obtener películas: {ex.Message}");
                return null;
            }
        }

        private string GetUrlByName(string name)
        {
            string textoModificado = "";
            bool espacioPrevio = false;

            foreach (char c in name)
            {
                if (c == ' ')
                {
                    // Si hay más de un espacio consecutivo, ignoramos los espacios adicionales
                    if (!espacioPrevio)
                    {
                        textoModificado += "+";
                        espacioPrevio = true;
                    }
                }
                else
                {
                    textoModificado += c;
                    espacioPrevio = false;
                }
            }
            return string.Format("{0}{1}",ApiUrl.GetMovieByName,textoModificado);
        }
    }
}
