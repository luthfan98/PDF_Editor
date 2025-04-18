using System;
using System.Windows.Forms;
using PdfiumViewer;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Editor
{
    public partial class Form1 : Form
    {
        private PdfViewer pdfViewer; // Deklarasi PdfViewer
        private float zoomLevel = 1.0f; // Default 100%
        private int currentDpi = 96; // Default 96 DPI (100%)

        public Form1()
        {
            InitializeComponent();

            // Inisialisasi pdfViewer dan letakkan di dalam groupBox1
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(pdfViewer); // <-- Penting: ke groupBox1, bukan ke form langsung
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pdfViewer.Document?.Dispose();
                        pdfViewer.Document = PdfiumViewer.PdfDocument.Load(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var document = pdfViewer.Document;
                    if (document != null)
                    {
                        try
                        {
                            document.Save(dlg.FileName);
                            MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to save PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No PDF is loaded to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfSharp.Pdf.PdfDocument outputDocument = new PdfSharp.Pdf.PdfDocument();

                        foreach (string file in dlg.FileNames)
                        {
                            PdfSharp.Pdf.PdfDocument inputDocument = PdfSharp.Pdf.IO.PdfReader.Open(file, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                            for (int idx = 0; idx < inputDocument.PageCount; idx++)
                            {
                                outputDocument.AddPage(inputDocument.Pages[idx]);
                            }
                        }

                        using (SaveFileDialog saveDlg = new SaveFileDialog())
                        {
                            saveDlg.Filter = "PDF files (*.pdf)|*.pdf";
                            if (saveDlg.ShowDialog() == DialogResult.OK)
                            {
                                outputDocument.Save(saveDlg.FileName);
                                MessageBox.Show("PDFs merged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // >>> Tambahan: Buka file hasil merge langsung
                                pdfViewer.Document?.Dispose();
                                pdfViewer.Document = PdfiumViewer.PdfDocument.Load(saveDlg.FileName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to merge PDFs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Buka dokumen PDF untuk di-modify
                        PdfSharp.Pdf.PdfDocument inputDocument = PdfReader.Open(dlg.FileName, PdfDocumentOpenMode.Modify);

                        // Minta input user halaman yang mau di-rotate
                        string inputPage = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter page number to rotate (1 - " + inputDocument.PageCount.ToString() + "):",
                            "Rotate Page");

                        int pageNumber;
                        if (int.TryParse(inputPage, out pageNumber))
                        {
                            if (pageNumber >= 1 && pageNumber <= inputDocument.PageCount)
                            {
                                // Rotate halaman yang dipilih 90 derajat searah jarum jam
                                PdfSharp.Pdf.PdfPage page = inputDocument.Pages[pageNumber - 1];
                                page.Rotate = (page.Rotate + 90) % 360;

                                using (SaveFileDialog saveDlg = new SaveFileDialog())
                                {
                                    saveDlg.Filter = "PDF files (*.pdf)|*.pdf";
                                    if (saveDlg.ShowDialog() == DialogResult.OK)
                                    {
                                        inputDocument.Save(saveDlg.FileName);
                                        MessageBox.Show("Page rotated and file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Reload file hasil rotasi ke viewer
                                        pdfViewer.Document?.Dispose();
                                        pdfViewer.Document = PdfiumViewer.PdfDocument.Load(saveDlg.FileName);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid page number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input. Please enter a valid page number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to rotate page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnSearchText_Click(object sender, EventArgs e)
        {
            if (pdfViewer.Document != null)
            {
                MessageBox.Show("Search functionality is not available in this version.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnZoomFitWidth_Click(object sender, EventArgs e)
        {
            if (pdfViewer != null)
            {
                pdfViewer.ZoomMode = PdfViewerZoomMode.FitWidth;
            }
        }

        private void btnZoomActualSize_Click(object sender, EventArgs e)
        {
            if (pdfViewer != null)
            {
                pdfViewer.ZoomMode = PdfViewerZoomMode.FitBest;
            }
        }

        private void btnZoomFitHeight_Click(object sender, EventArgs e)
        {
            if (pdfViewer != null)
            {
                pdfViewer.ZoomMode = PdfViewerZoomMode.FitHeight;
            }
        }

        private void btnDeletePage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Buka file PDF yang dipilih
                        PdfSharp.Pdf.PdfDocument inputDocument = PdfReader.Open(dlg.FileName, PdfDocumentOpenMode.Modify);

                        // Minta user memasukkan nomor halaman yang mau dihapus
                        string inputPage = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter page number to delete (1 - " + inputDocument.PageCount.ToString() + "):",
                            "Delete Page");

                        int pageNumber;
                        if (int.TryParse(inputPage, out pageNumber))
                        {
                            if (pageNumber >= 1 && pageNumber <= inputDocument.PageCount)
                            {
                                // Hapus halaman (ingat: index mulai dari 0)
                                inputDocument.Pages.RemoveAt(pageNumber - 1);

                                using (SaveFileDialog saveDlg = new SaveFileDialog())
                                {
                                    saveDlg.Filter = "PDF files (*.pdf)|*.pdf";
                                    if (saveDlg.ShowDialog() == DialogResult.OK)
                                    {
                                        // Simpan hasil file baru
                                        inputDocument.Save(saveDlg.FileName);
                                        MessageBox.Show("Page deleted and file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Reload hasil file baru ke viewer
                                        pdfViewer.Document?.Dispose();
                                        pdfViewer.Document = PdfiumViewer.PdfDocument.Load(saveDlg.FileName);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid page number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input. Please enter a valid page number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
    }
}
