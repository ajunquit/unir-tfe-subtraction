namespace UNIR.TFE.Polyrepo.Subtraction.Module.Application
{
    public class SubtractionAppService : ISubtractionAppService
    {
        public string Key => "sub";

        public decimal Execute(decimal a, decimal b) => a - b;
    }
}
