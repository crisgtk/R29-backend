using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Config
{
    public class Result
    {
        public int status { get; set; }
        public object value { get; set; }
        public string message { get; set; }
        public string errorMessage { get; set; }

        public static Result Success(object _value, string _message = "succcess")
        {
            return new Result
            {
                status = 0,
                value = _value,
                message = _message
            };
        }

        public static Result Fail(string _errorMessage)
        {
            return new Result
            {
                status = -1,
                message = "Error - Comunicarse con Soporte",
                errorMessage = _errorMessage
            };
        }

        public static Result ModelIsNotValid(ModelStateDictionary _modelSate)
        {

            List<ErrorModel> errores = new List<ErrorModel>();


            foreach (var _atributo in _modelSate)
            {
                if (_atributo.Value.Errors.Count > 0)
                {
                    foreach (var _atributoError in _atributo.Value.Errors)
                    {
                        errores.Add(new ErrorModel
                        {
                            atributo = _atributo.Key,
                            typeError = _atributoError.Exception == null ? 0 : 1,
                            message = _atributoError.Exception == null ? _atributoError.ErrorMessage : "Error - Comunicarse con Soporte",
                            errorMenssage = _atributoError.Exception == null ? "" : _atributoError.Exception.Message
                        });
                    }
                }
            }
            return new Result
            {
                status = -2,
                value = errores,
                message = "Revisar informacion enviada",
                errorMessage = "error en modelo"
            };
        }

        public class ErrorModel
        {
            public string atributo { get; set; }
            public int typeError { get; set; }
            public string message { get; set; }
            public string errorMenssage { get; set; }
        }
    }
}