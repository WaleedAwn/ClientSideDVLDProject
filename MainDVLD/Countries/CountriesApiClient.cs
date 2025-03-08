using MainDVLD.Countries.DTOs;
using MainDVLD.Globals;
using MainDVLD.HttpConnection;
using MainDVLD.People.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Countries
{
    public class CountriesApiClient
    {
        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "Countries/";

        
        public static async Task<ApiResult<List<CountriesDTO>>> GetAllCountriesStatic()
        {
            var apiResult = new ApiResult<List<CountriesDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + "All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var countries = await _staticHttpClient.GetFromJsonAsync<List<CountriesDTO>>(_endPoint + "All");
                    apiResult.Result = countries;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = ApiResponseStatus.NotFound;
                    // if there is any message in the body 
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");

            }



            return apiResult;


            
        }

       public async Task<ApiResult<List<CountriesDTO>>> GetAllCountries()
        {
            return await GetAllCountriesStatic();
        }
        
        public static async Task<ApiResult<CountriesDTO>> FindByCountryIDstatic(int CountryId)
        {
            var apiResult = new ApiResult<CountriesDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + $"FindByID/{CountryId}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Country = await response.Content.ReadFromJsonAsync<CountriesDTO>();
                    apiResult.Result = Country;
                }

                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        _ => ApiResponseStatus.ServerError,
                    };
                    // if there any message in the body will be stored in ErrorMessage
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }


            }
            catch (Exception ex)
            {
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");
            }
            return apiResult;
        }
        public  async Task<ApiResult<CountriesDTO>> FindByCountryID(int CountryId)
        {
            return await FindByCountryIDstatic(CountryId);
        }

        public static async Task<ApiResult<CountriesDTO>> FindCountryNameStatic(string CountryName)
        {
            var apiResult = new ApiResult<CountriesDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + $"FindByName/{CountryName}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Country = await response.Content.ReadFromJsonAsync<CountriesDTO>();
                    apiResult.Result = Country;
                }

                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        _ => ApiResponseStatus.ServerError,
                    };
                    // if there any message in the body will be stored in ErrorMessage
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }


            }
            catch (Exception ex)
            {
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");
            }
            return apiResult;
        }
        public async Task<ApiResult<CountriesDTO>> FindCountryInfoByName(string CountryName)
        {
            return await FindCountryNameStatic(CountryName);
           
        }

        public async Task<ApiResult<bool>> IsCountryExist(int COuntryId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsExist/{COuntryId}");
                if (response.IsSuccessStatusCode)
                {
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = true;
                    apiResult.IsSuccess = true;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Result = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,
                    };
                }
                apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                //Logger logger = new Logger(LoggingMethod.EventLogger);
                //logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }



        public async Task<ApiResult<CountriesDTO>> AddNewCountry(CountriesDTO newCountry)
        {
            var apiResult = new ApiResult<CountriesDTO>();
            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint + "Add", newCountry);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<CountriesDTO>();
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                }
                else
                {
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,
                        _ => ApiResponseStatus.ServerError,

                    };
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                //Logger logger = new Logger(LoggingMethod.EventLogger);
                //logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }

        public async Task<ApiResult<CountriesDTO>> UpdateCountryInfo(int CountryId, CountriesDTO UpdateCountry)
        {


            var apiResult = new ApiResult<CountriesDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint + $"Update/{CountryId}", UpdateCountry);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<CountriesDTO>();

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,
                        _ => ApiResponseStatus.ServerError,

                    };
                    // if there is any error message in the body
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                //Logger logger = new Logger(LoggingMethod.EventLogger);
                //logger.Log($"User Error: {ex.Message}");

            }
            return apiResult;
        }

        public async Task<ApiResult<bool>> DeletePerson(int CountryID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint + $"Delete/{CountryID}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = true;
                    apiResult.IsSuccess = true;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Result = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,
                    };
                }
                apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                //Logger logger = new Logger(LoggingMethod.EventLogger);
                //logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }

    }
}
