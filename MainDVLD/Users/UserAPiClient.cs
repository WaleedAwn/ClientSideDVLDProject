using MainDVLD.Globals;
using MainDVLD.HttpConnection;
using MainDVLD.People;
using MainDVLD.People.DTOs;
using MainDVLD.Users.DTOs;
using System.Net.Http.Json;

namespace MainDVLD.Users
{
    public class UserAPiClient
    {


        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "Users/";
        public async Task<ApiResult<List<PersonUserDTO>>> GetAllUsers()
        {
            var apiResult = new ApiResult<List<PersonUserDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + "All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var users = await _staticHttpClient.GetFromJsonAsync<List<PersonUserDTO>>(_endPoint + "All");
                    apiResult.Result = users;
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


        public  async Task<ApiResult<UsersDTO>> FindByUserID(int UserID)
        {
            var apiResult = new ApiResult<UsersDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + $"FindByID/{UserID}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var user = await response.Content.ReadFromJsonAsync<UsersDTO>();
                    apiResult.Result = user;
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

        public async Task<ApiResult<UsersDTO>> FindByUserName(string UserName)
        {
            var apiResult = new ApiResult<UsersDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + $"FindByName/{UserName}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var user = await response.Content.ReadFromJsonAsync<UsersDTO>();
                    apiResult.Result = user;
                }

                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        _=> ApiResponseStatus.ServerError,
                    };
                    // if there any message in the body will be stored in ErrorMessage
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }


            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message+" Server Disconnected");
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");
            }
            return apiResult;
        }


        public async Task<ApiResult<bool>> ISUserExist(int UserID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsExist/{UserID}");
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
        public static async Task<ApiResult<bool>> IsPersonExistAsUser(int PersonID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsPersonExistAsUser/{PersonID}");
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

        public async Task<ApiResult<bool>> ISUserUserNameExist(string UserName)
        {
            var apiResult = new ApiResult<bool>();
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsUserNameExist/{UserName}");
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


        public async Task<ApiResult<UsersDTO>> AddNewUser(UsersDTO newUser)
        {
            var apiResult = new ApiResult<UsersDTO>();
            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint + "Add", newUser);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<UsersDTO>();
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

        public async Task<ApiResult<UsersDTO>> UpdateUserInfo(int UserID, UsersDTO UpdateUser)
        {


            var apiResult = new ApiResult<UsersDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint + $"Update/{UserID}", UpdateUser);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<UsersDTO>();

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

        public  static async Task<ApiResult<bool>> DeleteUser(int UserID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint + $"Delete/{UserID}");

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
