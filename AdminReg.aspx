<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="AdminReg.aspx.cs" Inherits="AdminReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="main">
        <section id="contact" class="four">
			<div class="container">
                 
                <!-- Admin Reg -->
                <header>
                     <h2>Admin | Sign Up</h2>
                </header>

                <form method="post" action="AdminPro.aspx">
                    <div class="allign">
						<div class="row half">
							<div class="6u">
                                <asp:TextBox ID="Txtname" runat="server" placeholder="*Name" class="text"></asp:TextBox>               
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                   ControlToValidate="Txtname" ErrorMessage="Your Name Please!" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>                                  
                        </div>

                         <div class="row half">
                             <div class="6u">
                                 <asp:TextBox ID="Txtmail" runat="server" placeholder="Email ID" class="text"></asp:TextBox>
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                     ControlToValidate="Txtmail" ErrorMessage="Re-Check!" 
                                     ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF5050"></asp:RegularExpressionValidator>
                             </div>
                         </div>

                         <div class="row half">                          
                             <div class="6u">
                                  <asp:TextBox ID="Txtid" runat="server" placeholder="*Employee ID" class="text" OnTextChanged="Txtid_TextChanged"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                      ControlToValidate="Txtid" ErrorMessage="Mail-ID Please!" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                             </div>
                         </div>

                         <div class="row half">
                             <div class="6u">
                                 <asp:TextBox ID="Txtdesig" runat="server" placeholder="*Designation" class="text"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Txtdesig" ErrorMessage="Designation Please!" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                              </div>                                      
                         </div>

                         <div class="row half" >    
                              <div class="6u">
                                   <asp:TextBox ID="Txtpass" runat="server" placeholder="*Password" class="text" Type="Password"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                       ControlToValidate="Txtpass" ErrorMessage="Password Please!" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                              </div>
                          </div>
                      </div>
                    </form>
							
                <!-- Click Event -->	
                <div class="row">
					<div class="12u">
						<asp:Button ID="Btnsubmit" runat="server" Text="Submit"
                             onclick="Btnsubmit_Click" CssClass="button"></asp:Button>
					</div>
				</div>
			</div>		
		</section>

    </div>
</asp:Content>

