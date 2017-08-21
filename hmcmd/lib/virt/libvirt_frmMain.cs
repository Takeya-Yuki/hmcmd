using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hmcmd.var.virt;

namespace hmcmd.lib.virt
{
    public partial class libvirt_frmMain : Form
    {
        public libvirt_frmMain()
        {
            InitializeComponent();
            InitRes();
        }

        public void InitRes()
        {
            ComponentResourceManager virtres = new ComponentResourceManager(typeof(virtres));
            this.toolStripButton1.Image = (Image)virtres.GetObject("vm_new_32px");
            this.toolStripButton2.Image = (Image)virtres.GetObject("vm_settings_32px");
            this.toolStripButton3.Image = (Image)virtres.GetObject("vm_start_32px");
            this.toolStripButton4.Image = (Image)virtres.GetObject("vm_reset_16px_hidpi");

            var il=new ImageList();
            il.ImageSize=new Size(32,32);
            listView1.LargeImageList = il;
            listView1.SmallImageList = il;
            listView1.StateImageList = il;
            listView1.Items[0].ImageList.Images.Add((Image)virtres.GetObject("os_win10_64"));
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageList.Images.Add((Image)virtres.GetObject("os_archlinux_64"));
            listView1.Items[1].ImageIndex = 1;
        }
    }
}
