using System;
using System.Text.RegularExpressions;
using Enums;
using Models;

namespace service
{
    public class Caller
    {
        public ResultModel result;
        public ExecModel model;
        public Caller(ExecModel model)
        {
            this.model=model;
            
        }

        public ResponseModel<ResultModel> Output(){
            ResponseModel<ResultModel> response = null;
            this.result=null;
            try{
                //Regex regex = new Regex(@"\\");
                //var tt=string.Format("{0}", model.Data1.Replace("\"","\\\\\\\""));
                //var args = string.Format("{0} {1} \"{2}\" ", model.Arg0, model.Arg1, tt); //"{\\\"data\\\":[1, 2, 3, 3, 2, 1]}");
                var args = string.Format("{0} {1} \"{2}\" ", model.Arg0, model.Arg1, model.Data1);
                var timeInit = DateTime.Now;
                Console.WriteLine(timeInit);
                var res = new RunCmd().Run(model.Interpreter, model.ScriptFile, args);
                var tt = DateTime.Now.Subtract(timeInit);
                Console.WriteLine(timeInit.Subtract(DateTime.Now));
                this.result= new ResultModel{
                        Name= this.model.Name,
                        timeExec= tt,
                        Result=res
                };
               
                
                response = new ResponseModel<ResultModel>
                {
                    Message = "Request Solve",
                    Code = ResponseCodes.Success,
                    Response = this.result
                };
            }
            catch (Exception ex){
                this.result.Result += $" ERROR: {ex.Message}";
                response = new ResponseModel<ResultModel>
                {
                    Message = "Request Solve Failed",
                    Code = ResponseCodes.GeneralError,
                    Response = this.result
                };
            }
            return response;
        }
    }
}