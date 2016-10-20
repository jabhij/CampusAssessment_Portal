<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paper.aspx.cs" Inherits="paper" EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="main">
        <section id="contact" class="four">

        <div>
        <div class="3u">           
            <asp:Label ID="admin" runat="server"></asp:Label>
            <asp:LinkButton ID="admPro" runat="server" onclick="admPro_Click">Profile</asp:LinkButton>
        </div>
            
            <!-- Create option -->
            <div class="12u">
         <header>
                <h3>
                    Create | Assessment 
                </h3>
        </header>
        </div>
         </div>

            <div class="div-pane">
                <div class="row">               
                   <asp:DropDownList ID="Drpdwn" runat="server">
                       <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="6u">
                    <asp:Label ID="lblTxt1" runat="server" Text="" CssClass="lbl"></asp:Label>
                </div>
                <div class="tbl-grid">
                    <asp:GridView ID="TechView" runat="server" EnableViewState="true">
                    </asp:GridView>
                    </div>
                <div class="tbl-grid">
                    <asp:GridView ID="EngView" runat="server" EnableViewState="true">
                    </asp:GridView>
                    </div>
                <div class="tbl-grid">
                    <asp:GridView ID="AptView" runat="server" EnableViewState="true">
                    </asp:GridView>
                </div>            
                <div>
                    <asp:Button ID="Btntech" runat="server" Text="Technical" CssClass="button" OnClick="Btntech_Click"></asp:Button>
                    <asp:Button ID="Btncom" runat="server" Text="Comprehensive" CssClass="button" OnClick="Btncom_Click"></asp:Button>
                    <asp:Button ID="Btnapp" runat="server" Text="Apptitude" CssClass="button" OnClick="Btnapp_Click"></asp:Button>
                </div><div>&nbsp;</div>
                <div>
                    <asp:Button ID="Btnadd" runat="server" Text="ADD" CssClass="button" OnClick="Btnadd_Click"></asp:Button>
                </div>
            </div>              
         </section>    
     </div>
</div>
    </div>
</asp:Content>

