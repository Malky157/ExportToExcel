using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace DeveloperProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new FacilityRepository();
            var facilities = repo.GetFacilities();          
            var allowedFacilities = facilities.FindAll(f => f.Live);
            var response = ExportToExcelFacilityList(allowedFacilities);
            Console.WriteLine(response);
            Console.ReadKey(true);
        }

        public static Response ExportToExcelFacilityList(List<Facility> facilities)
        {

            try
            {
                ExportToExcel(facilities, "facilities.xlsx");

                return new Response()
                {
                    Success = true,
                    FileName = "facilities.xlsx"
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    Success = false,
                    Errors = ex.Message
                };
            }
        }

        public static void ExportToExcel(List<Facility> facilities, string fileName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excel = new ExcelPackage();

            excel.Workbook.Properties.Title = fileName;           
            excel.Workbook.Properties.Created = DateTime.Now;

            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
            workSheet.Cells[1, 1].LoadFromCollection(facilities, true);
            var file = Path.Join("C:\\Users\\Malky\\Downloads", fileName);
            excel.SaveAs(file);
        }
    }
}