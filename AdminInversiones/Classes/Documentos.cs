using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace AdminInversiones
{
    internal class Documentos
    {
        public Documentos()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        
        public void GuardarArchivoExcel(List<Inversiones> inversion,List<double> intereses, List<int> dias, FileInfo file)
        {
            BorrarSiExiste(file);
            var package = new ExcelPackage(file);
            var ws = package.Workbook.Worksheets.Add("Inversiones");
            ws.Cells["A1"].LoadFromCollection(inversion,true).AutoFitColumns();
            ws.Cells["G2"].LoadFromCollection(intereses,false).AutoFitColumns();
            ws.Cells["H2"].LoadFromCollection(dias, false).AutoFitColumns();
            package.Save();
            package.Dispose();
        }

        private static void BorrarSiExiste(FileInfo file)
        {
            if (file.Exists) file.Delete();
        }
    }
}
