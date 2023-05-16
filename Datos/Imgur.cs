using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Datos
{
    public class Imgur
    {
        private dynamic json;
        public dynamic Json { get => json; set => json = value; }

        public Imgur()
        {

        }

        public async Task<string> SubirImagen(byte[] imgBt)
        {


            string apiKey = "f84f7d23f1f95ec";

            // Crea una nueva solicitud HTTP POST
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Client-ID " + apiKey);

                // Crea un nuevo objeto MultipartFormDataContent y agrega el arreglo de bytes de la imagen
                var content = new MultipartFormDataContent();
                content.Add(new ByteArrayContent(imgBt), "image", "image.jpg");
                content.Add(new StringContent("hidden"), "privacy");
                content.Add(new StringContent("Prueba Cedula"), "title");
                //content.Add(new StringContent(true.ToString()), "in_gallery");


                // Envía la solicitud a la URL de la API de Imgur
                var response = await client.PostAsync("https://api.imgur.com/3/image", content);

                // Si la solicitud es exitosa, obtén la URL de la imagen subida
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    dynamic jsonData = JsonConvert.DeserializeObject(responseJson)!;
                    Json = jsonData;

                }
                else
                {
                    Debug.WriteLine("FAIL");
                    Json = "FAIL";
                }
            }
            return Json.data.link;
        }
    }
}
