<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateA.aspx.cs" Inherits="CreateA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="main">
        <section id="contact" class="four">

            <div class="container">

            <!-- Profile Options -->
      <div>
        <div class="3u">
            <asp:Label ID="candid" runat="server" ></asp:Label>
            <asp:LinkButton ID="candidout" runat="server" onclick="candidout_Click">Profile</asp:LinkButton>
        </div>
        <div class="12u">
                   <header>
		        <h3>Assessment</h3>
		           </header> 
          </div>
          </div>
                <!-- Section: Row Display -->
                <section>
            <div class="row">
                <div class="8u">
                    <asp:Label ID="Lblrow" runat="server" Text="Selected Rows:"></asp:Label>
                </div>
                <div class="4u">
                    <asp:TextBox ID="Txtrow" runat="server" class="text"></asp:TextBox>
                    </div>               
            </div>
                    </section>

                <!-- Tables: Containing Data -->
                <section class="">
            <div class="tbl-grid" "tbl-grid1">
                <asp:GridView ID="Grvassessment1" runat="server" >
                </asp:GridView>
             </div>
            <div class="tbl-grid">
                <asp:GridView ID="Grvassessment" runat="server" Class="grv" >
                </asp:GridView>
            </div>
                    </section>

                </div>
            </section>

         <!-- Button: Save Event -->
         <section>           
                <asp:Button ID="Btnsave" runat="server" Text="Save" CssClass="button" OnClick="Btnsave_Click"></asp:Button>  
             <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="btnBack_Click"/>          
        </section>
     </div>
</asp:Content>
