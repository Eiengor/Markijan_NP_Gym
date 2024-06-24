using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markijan_NP_Gym.Models;
using Markijan_NP_Gym.Services.Abstract;
using Markijan_NP_Gym.Services.Concreate;
using Markijan_NP_Gym.Repositories.Concreate.Factories;
using Markijan_NP_Gym.Logging;
using Markijan_NP_Gym.Repositories.Abstract;
namespace gymForm
{
    public partial class Form1 : Form
    {
        private IMemberService memberService;
        private IMemberRep memberRep;
        private IMembershipRep membershipRep;
        public Form1()
        {
            var factory = FactoryProvider.GetReposFactory();
            memberRep = factory.GetMemberRep();
            membershipRep = factory.GetMembershipRep();
            memberService = new MemberService();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshMembers();
            RefreshMemberships();
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                memberRep.Add(new Member
                {
                    FirstName = firstNameBox.Text,
                    LastName = lastNameBox.Text,
                    Age = Convert.ToInt32(ageBox.Text)
                });
                RefreshMembers();
            }
            catch (Exception ex)
            {
                Logger.Instance.LogError(ex.Message);
                label8.Text = ex.Message;
            };
        }
        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            try
            {
                membershipRep.Add(new Membership
                {
                    Name = MembershipNameBox.Text,
                    Price = Convert.ToSingle(MembershipPriceBox.Text)
                });
                RefreshMemberships();
            }
            catch (Exception ex)
            {
                Logger.Instance.LogError(ex.Message);
                label11.Text = ex.Message;
            };

        }
        private void RefreshMembers()
        {
            dataGridView1.DataSource = null;
            memberRep.Refresh();
            dataGridView1.DataSource = memberRep.GetAll();
            lblOldestMember.Text = memberService.GetOldestMember(memberRep.GetAll()).FirstName +
                " " + memberService.GetOldestMember(memberRep.GetAll()).LastName;
        }
        private void RefreshMemberships()
        {
            dataGridView2.DataSource = null;
            membershipRep.Refresh();
            dataGridView2.DataSource = membershipRep.GetAll();
        }
    }
}
