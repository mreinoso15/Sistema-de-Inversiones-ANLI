using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AdminInversiones
{
    internal class Documentos
    {
        public Documentos()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        
        public void GuardarArchivoExcel(List<Depositos> deposito,List<DepositosCalculados> depositoCalc, List<Retiros> retiros)
        {
            if (deposito != null || depositoCalc != null || retiros != null)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "Archivos Excel(*.xlsx)|*.xlsx";
                savefile.FileName = string.Format("{0}.xlsx", "Inversiones - " + DateTime.Now.ToString("dd-MM-yyyy"));
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        int nuevaCelda = deposito.Count + 2;

                        var package = new ExcelPackage(stream);
                        var ws = package.Workbook.Worksheets.Add("Depositos");
                        var ws2 = package.Workbook.Worksheets.Add("Retiros");
                        if (deposito != null)
                            ws.Cells["A1"].LoadFromCollection(deposito, true).AutoFitColumns();
                        if (depositoCalc.Count > 0)
                            ws.Cells["A" + nuevaCelda].LoadFromCollection(depositoCalc).AutoFitColumns();
                        if (retiros != null)
                            ws2.Cells["A1"].LoadFromCollection(retiros, true).AutoFitColumns();
                        package.Save();
                        package.Dispose();
                        MessageBox.Show("El archivo fue creado correctamente", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //using
                }//IF interior
                else
                {
                    MessageBox.Show("No hay datos en ese rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        public void GuardarArchivoExcel(List<Usuario> usuarios)
        {
            if (usuarios != null )
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "Archivos Excel(*.xlsx)|*.xlsx";
                savefile.FileName = string.Format("{0}.xlsx", "Usuarios - " + DateTime.Now.ToString("dd-MM-yyyy"));
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                       

                        var package = new ExcelPackage(stream);
                        var ws = package.Workbook.Worksheets.Add("Usuarios");
                                               
                        ws.Cells["A1"].LoadFromCollection(usuarios, true).AutoFitColumns();
                       
                        package.Save();
                        package.Dispose();
                        MessageBox.Show("El archivo fue creado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //using
                }//IF interior
                else
                {
                    MessageBox.Show("No hay datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GuardarArchivoExcel(List<HistorialTasas> tasa)
        {
            if (tasa != null)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "Archivos Excel(*.xlsx)|*.xlsx";
                savefile.FileName = string.Format("{0}.xlsx", "Historial Tasas - " + DateTime.Now.ToString("dd-MM-yyyy"));
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {


                        var package = new ExcelPackage(stream);
                        var ws = package.Workbook.Worksheets.Add("Usuarios");

                        ws.Cells["A1"].LoadFromCollection(tasa, true).AutoFitColumns();

                        package.Save();
                        package.Dispose();
                        MessageBox.Show("El archivo fue creado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //using
                }//IF interior
                else
                {
                    MessageBox.Show("No hay datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
