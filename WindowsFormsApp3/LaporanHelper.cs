using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public static class LaporanHelper
    {
        /// <summary>
        /// Mengekspor DataGridView menjadi file HTML bergaya modern dan membukanya di browser untuk Cetak / Save PDF.
        /// </summary>
        public static void CetakKeBrowser(DataGridView dgv, string judulLaporan, string subJudul = "")
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                StringBuilder html = new StringBuilder();
                html.AppendLine("<!DOCTYPE html>");
                html.AppendLine("<html lang='id'>");
                html.AppendLine("<head>");
                html.AppendLine("<meta charset='UTF-8'>");
                html.AppendLine($"<title>{judulLaporan}</title>");
                html.AppendLine("<style>");
                html.AppendLine("body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 30px; color: #333; }");
                html.AppendLine(".header { text-align: center; border-bottom: 3px double #2c3e50; padding-bottom: 15px; margin-bottom: 25px; }");
                html.AppendLine(".header h1 { margin: 0; font-size: 24px; color: #1e293b; text-transform: uppercase; }");
                html.AppendLine(".header h3 { margin: 5px 0 0 0; font-size: 14px; font-weight: normal; color: #64748b; }");
                html.AppendLine(".meta { margin-bottom: 20px; font-size: 13px; color: #475569; }");
                html.AppendLine(".meta table { width: 100%; border: none; }");
                html.AppendLine(".meta td { padding: 4px 8px; border: none; }");
                html.AppendLine("table.data-table { width: 100%; border-collapse: collapse; margin-top: 10px; font-size: 13px; }");
                html.AppendLine("table.data-table th, table.data-table td { border: 1px solid #cbd5e1; padding: 10px 12px; text-align: left; }");
                html.AppendLine("table.data-table th { background-color: #0f172a; color: #ffffff; font-weight: 600; text-transform: uppercase; font-size: 12px; }");
                html.AppendLine("table.data-table tr:nth-child(even) { background-color: #f8fafc; }");
                html.AppendLine(".badge-success { background: #dcfce7; color: #15803d; padding: 3px 8px; border-radius: 4px; font-weight: 600; font-size: 11px; }");
                html.AppendLine(".badge-warning { background: #fef9c3; color: #854d0e; padding: 3px 8px; border-radius: 4px; font-weight: 600; font-size: 11px; }");
                html.AppendLine(".badge-danger { background: #fee2e2; color: #b91c1c; padding: 3px 8px; border-radius: 4px; font-weight: 600; font-size: 11px; }");
                html.AppendLine(".footer { margin-top: 40px; display: flex; justify-content: space-between; font-size: 13px; }");
                html.AppendLine(".signature { text-align: center; width: 220px; }");
                html.AppendLine(".signature-space { height: 70px; }");
                html.AppendLine("@media print { .no-print { display: none; } body { margin: 15mm; } }");
                html.AppendLine(".btn-print { background: #2563eb; color: white; border: none; padding: 10px 20px; font-size: 14px; font-weight: bold; border-radius: 6px; cursor: pointer; margin-bottom: 20px; }");
                html.AppendLine(".btn-print:hover { background: #1d4ed8; }");
                html.AppendLine("</style>");
                html.AppendLine("</head>");
                html.AppendLine("<body>");

                html.AppendLine("<div class='no-print' style='text-align: right;'>");
                html.AppendLine("<button class='btn-print' onclick='window.print()'>🖨️ Cetak / Simpan PDF</button>");
                html.AppendLine("</div>");

                // Header Kop Surat
                html.AppendLine("<div class='header'>");
                html.AppendLine($"<h1>{judulLaporan}</h1>");
                html.AppendLine("<h3>SISTEM INFORMASI JURNAL PRAKTIK KERJA INDUSTRI (PRAKERIN / PKL)</h3>");
                if (!string.IsNullOrWhiteSpace(subJudul))
                {
                    html.AppendLine($"<p style='margin-top: 6px; font-weight: 600; color: #0284c7;'>{subJudul}</p>");
                }
                html.AppendLine("</div>");

                // Meta tanggal cetak
                html.AppendLine("<div class='meta'>");
                html.AppendLine("<table>");
                html.AppendLine($"<tr><td style='width: 150px;'><strong>Tanggal Cetak</strong></td><td>: {DateTime.Now.ToString("dd MMMM yyyy, HH:mm")} WIB</td></tr>");
                html.AppendLine($"<tr><td><strong>Total Data</strong></td><td>: {dgv.Rows.Count} baris</td></tr>");
                html.AppendLine("</table>");
                html.AppendLine("</div>");

                // Tabel Data
                html.AppendLine("<table class='data-table'>");
                html.AppendLine("<thead><tr>");
                html.AppendLine("<th style='width: 40px; text-align: center;'>No</th>");

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    // Lewati kolom tombol atau kolom gambar
                    if (col is DataGridViewButtonColumn || col is DataGridViewImageColumn) continue;
                    if (col.HeaderText.Trim().ToLower() == "edit" || col.HeaderText.Trim().ToLower() == "delete" || col.HeaderText.Trim().ToLower() == "hapus") continue;
                    html.AppendLine($"<th>{col.HeaderText}</th>");
                }
                html.AppendLine("</tr></thead>");
                html.AppendLine("<tbody>");

                int no = 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    html.AppendLine("<tr>");
                    html.AppendLine($"<td style='text-align: center;'>{no++}</td>");

                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (col is DataGridViewButtonColumn || col is DataGridViewImageColumn) continue;
                        if (col.HeaderText.Trim().ToLower() == "edit" || col.HeaderText.Trim().ToLower() == "delete" || col.HeaderText.Trim().ToLower() == "hapus") continue;

                        object val = row.Cells[col.Index].Value;
                        string textVal = val != null ? val.ToString() : "-";

                        // Format status badge jika ada
                        if (textVal == "Disetujui" || textVal == "Diverifikasi" || textVal == "Hadir" || textVal == "LULUS")
                        {
                            textVal = $"<span class='badge-success'>{textVal}</span>";
                        }
                        else if (textVal == "Menunggu" || textVal == "Izin" || textVal == "Sakit")
                        {
                            textVal = $"<span class='badge-warning'>{textVal}</span>";
                        }
                        else if (textVal == "Revisi" || textVal == "Ditolak" || textVal == "Alpa" || textVal == "TIDAK LULUS")
                        {
                            textVal = $"<span class='badge-danger'>{textVal}</span>";
                        }

                        html.AppendLine($"<td>{textVal}</td>");
                    }
                    html.AppendLine("</tr>");
                }

                html.AppendLine("</tbody>");
                html.AppendLine("</table>");

                // Footer tanda tangan
                html.AppendLine("<div class='footer'>");
                html.AppendLine("<div class='signature'>");
                html.AppendLine("<p>Mengetahui,<br><strong>Pembimbing Industri / PT</strong></p>");
                html.AppendLine("<div class='signature-space'></div>");
                html.AppendLine("<p>( ........................................ )</p>");
                html.AppendLine("</div>");

                html.AppendLine("<div class='signature'>");
                html.AppendLine($"<p>Dicetak pada {DateTime.Now.ToString("dd MMM yyyy")}<br><strong>Guru Pembimbing PKL</strong></p>");
                html.AppendLine("<div class='signature-space'></div>");
                html.AppendLine("<p>( ........................................ )</p>");
                html.AppendLine("</div>");
                html.AppendLine("</div>");

                html.AppendLine("</body>");
                html.AppendLine("</html>");

                // Tulis ke file temporer lalu buka
                string tempPath = Path.Combine(Path.GetTempPath(), $"Laporan_PKL_{DateTime.Now:yyyyMMdd_HHmmss}.html");
                File.WriteAllText(tempPath, html.ToString(), Encoding.UTF8);

                Process.Start(new ProcessStartInfo(tempPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencetak laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mengekspor DataGridView menjadi file CSV (dapat dibuka langsung di Microsoft Excel).
        /// </summary>
        public static void EksporKeCSV(DataGridView dgv, string namaDefaultFile)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = namaDefaultFile + "_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Header
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        var col = dgv.Columns[i];
                        if (col is DataGridViewButtonColumn || col is DataGridViewImageColumn) continue;
                        if (col.HeaderText.Trim().ToLower() == "edit" || col.HeaderText.Trim().ToLower() == "delete" || col.HeaderText.Trim().ToLower() == "hapus") continue;

                        sb.Append("\"" + col.HeaderText.Replace("\"", "\"\"") + "\"");
                        if (i < dgv.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();

                    // Data Rows
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            var col = dgv.Columns[i];
                            if (col is DataGridViewButtonColumn || col is DataGridViewImageColumn) continue;
                            if (col.HeaderText.Trim().ToLower() == "edit" || col.HeaderText.Trim().ToLower() == "delete" || col.HeaderText.Trim().ToLower() == "hapus") continue;

                            object val = row.Cells[i].Value;
                            string strVal = val != null ? val.ToString().Replace("\"", "\"\"") : "";
                            sb.Append("\"" + strVal + "\"");
                            if (i < dgv.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Data berhasil diekspor ke:\n" + sfd.FileName, "Ekspor Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

