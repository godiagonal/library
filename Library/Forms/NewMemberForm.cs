using Library.Helpers;
using Library.Models;
using Library.Services;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class NewMemberForm : MetroFramework.Forms.MetroForm
    {
        MemberService _memberService;
        public string NewMemberName { get; private set; }

        public NewMemberForm(MemberService memberService)
        {
            InitializeComponent();

            _memberService = memberService;
        }
    }
}
