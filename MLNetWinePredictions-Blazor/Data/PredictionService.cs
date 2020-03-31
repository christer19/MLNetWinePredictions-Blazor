using Microsoft.AspNetCore.Components;
using MLNetWinePredictions_Blazor.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MLNetWinePredictions_Blazor.Data
{
    public class PredictionService
    {
        private HttpClient _client;

        public PredictionService(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:59223/");

            _client = client;
        }

        public async Task<float> GetWinePrediction(WineModel model)
        {
            var prediction = await _client.PostJsonAsync<float>("/api/model", model);

            return prediction;
        }
    }
}
