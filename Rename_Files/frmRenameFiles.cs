using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename_Files
{
    public partial class frmRenameFiles : Form
    {
        String directoryPath;
        public frmRenameFiles()
        {
            InitializeComponent();
        }

        
        
        
        /********MAIN COMPUTATIONS********/

        //browse and select a directory for which the path will be inserted into the textbox
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryPath = folderBrowser.SelectedPath;
                txtDirectoryPath.Text = directoryPath;
            }
        }

        //clear all fields in the form
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Clear();
            txtMainText.Clear();
            txtOriginalExt.Text = ".";
            txtNewExtension.Clear();
            chkSameAsOriginal.Checked = true;
        }

        //process the file renaming according to the data entered
        private void btnRenameFiles_Click(object sender, EventArgs e)
        {

            //only execute if the validation passes and the user confirms their choice
            if (validateRename() == true)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to rename these files?", 
                "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                {
                    string[] filesArray = Directory.GetFiles(directoryPath, "*"+txtOriginalExt.Text);

                    String originalFile;
                    String newFile;
                    String mainText = "\\"+txtMainText.Text+"_";

                    for (int i=0; i<filesArray.Length; i++)
                    {                
                        originalFile = filesArray[i];
                        newFile = directoryPath + mainText + (i+1) + txtNewExtension.Text;
                        File.Move(originalFile, newFile);
                    }
                    successMessage("Successfully renamed files!");                
                }
            }

        }

        //update the directory variable if the path is entered manually
        private void txtDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            directoryPath = txtDirectoryPath.Text;
        }

        //deleting all files in the selected directory of a given file extension
        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            //only execute if validation passes and the user confirms their choice
            if(validateDelete() == true)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete these files?",
                "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                {
                    String originalExtension = txtOriginalExt.Text;
                    string[] filesArray = Directory.GetFiles(directoryPath, "*" + originalExtension);

                    for (int i = 0; i < filesArray.Length; i++)
                    {
                        File.Delete(filesArray[i]);
                    }
                    successMessage("Successfully deleted "+originalExtension+" files!");
                }
                
            }
        }

        //copy original to new extension when checkbox is selected
        private void chkSameAsOriginal_CheckedChanged(object sender, EventArgs e)
        {
            sameAsOriginalChecked();
        }

        //upon loading the form
        private void frmRenameFiles_Load(object sender, EventArgs e)
        {
            chkSameAsOriginal.Checked = true;
            txtOriginalExt.Text = ".";
        }        

        //copy original to new extension if checkbox is selected
        private void sameAsOriginalChecked()
        {
            if(chkSameAsOriginal.Checked == true)
            {
                txtNewExtension.Text = txtOriginalExt.Text;
            }
        }





        /**********VALIDATION************/

        //copy original to new extension if checkbox is selected
        //there must always be a period at the beginning of the file extension
        private void txtOriginalExt_TextChanged(object sender, EventArgs e)
        {
            sameAsOriginalChecked();
            originalExtensionEmpty();
        }

        //there must always be a period at the beginning of the file extension
        private void txtNewExtension_TextChanged(object sender, EventArgs e)
        {
            originalExtensionEmpty();
            newExtensionEmpty();
        }

        //there must always be a period at the beginning of the file extension
        private void originalExtensionEmpty()
        {
            if (txtOriginalExt.Text == "")
            {
                txtOriginalExt.Text = ".";
            }
            else if (txtOriginalExt.Text.Substring(0, 1) != ".")
            {
                txtOriginalExt.Text = "." + txtOriginalExt.Text;
            }
            txtOriginalExt.SelectionStart = txtOriginalExt.Text.Length;
        }

        //there must always be a period at the beginning of the file extension
        private void newExtensionEmpty()
        {
            if (txtNewExtension.Text == "")
            {
                txtNewExtension.Text = ".";
                txtNewExtension.SelectionStart = txtNewExtension.Text.Length;
            }
            else if (txtNewExtension.Text.Substring(0, 1) != ".")
            {
                txtNewExtension.Text = "." + txtNewExtension.Text;
                txtNewExtension.SelectionStart = txtNewExtension.Text.Length;
            }
        }

        //validate fields before renaming the files
        private bool validateRename()
        {
            if(txtMainText.Text == "")
            {
                errorMessage("Main text field is empty!");
                return false;
            }
            else if(txtNewExtension.Text == ".")
            {
                errorMessage("You have not entered a new file extension!");
                return false;
            }
            else if(validateDirectoryPath() == false) {return false;}

            return true;
        }

        //reject empty or invalid directory path
        private bool validateDirectoryPath()
        {
            if(txtDirectoryPath.Text == "")
            {
                errorMessage("You have not selected a directory path!");
                return false;
            }
            else if(Directory.Exists(directoryPath) == false)
            {
                errorMessage("Please select a valid directory path!");
                return false;
            }
            return true;
        }

        //validate fields before deleting files
        private bool validateDelete()
        {
            if(txtOriginalExt.Text == ".")
            {
                errorMessage("You have not entered an original file extension!");
                return false;
            }
            else if (validateDirectoryPath() == false) { return false; }

            return true;
        }





        /***********GENERIC METHODS**********/

        //output a successful message box
        private void successMessage(String message)
        {
            MessageBox.Show(message, "Success!", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //output an error in a message box
        private void errorMessage(String message)
        {
            MessageBox.Show("Error: "+message, "Error!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
