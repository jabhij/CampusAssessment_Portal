<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" EnableEventValidation="true" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="main">
        <section id="contact" class="four">
         <div class="container">

             <!-- option for Admin -->
           <header>
		        <h3>Admin  | LogIn</h3>
		   </header>  
             <div class="allign">
                 <div class="6u">
                     <asp:TextBox ID="Txtid" runat="server" placeholder="Admin ID" class="text">
                     </asp:TextBox>
                 </div>
                 <div class="6u">
                     <asp:TextBox ID="Txtpass" runat="server" placeholder="Password" class="text" Type="password">
                     </asp:TextBox>
                 </div>
              </div>  <div>&nbsp;</div>
              <div>
                  <asp:Button ID="Btnlogin" runat="server" Text="Log In" CssClass="button" CausesValidation="false" OnClick="Btnlogin_Click">
                  </asp:Button>
              </div>   <div>&nbsp;</div>

        <!-- option for candidate -->
           <header>
		        <h3>Candidate | LogIn</h3>
		   </header>
            <div class="allign">
               <div class="6u">
                   <asp:TextBox ID="Txtroll" runat="server" placeholder="Roll No" class="text">
                   </asp:TextBox>
               </div>
               <div class="6u">
                   <asp:TextBox ID="Txtname" runat="server" placeholder="Password" class="text" Type="password">
                   </asp:TextBox>
               </div>
            </div>  <div>&nbsp;</div>
            <div>
               <asp:Button ID="Btnlogin1" runat="server" Text="Log In" CssClass="button" OnClick="Btnlogin1_Click">
               </asp:Button>
            </div>
         </div>
       </section>
 </div>
</asp:Content>
