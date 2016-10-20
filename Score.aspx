<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPro.master" AutoEventWireup="true" CodeFile="Score.aspx.cs" Inherits="Score" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
        <section id="contact" class="four">
         <header>
	    	 <h3>Score Card</h3>
		 </header>
            <div class="row">
            <div class="6u">
                <asp:DropDownList ID="drpDwnInstitute" runat="server" OnSelectedIndexChanged="drpDwnInstitute_SelectedIndexChanged" ></asp:DropDownList>
            </div>
            <div class="6u">
                <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" CssClass="button"></asp:Button>
            </div> 
                </div>
             <div class="tbl-grid">
                <asp:GridView ID="Grdscore" runat="server" ></asp:GridView>
            </div>
    </div>
</div>
    </div>
    </div>
    </div>
    </div>
</asp:Content>

