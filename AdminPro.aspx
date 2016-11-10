<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPro.master" AutoEventWireup="true" CodeFile="AdminPro.aspx.cs" Inherits="AdminPro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="main">
        <section id="contact" class="four">
        <header>
	    	 <h3>Admin  | Profile</h3>
		 </header>

	   <div class="container">

          <!-- Admin Description -->
          <div class="admin-profile">

              <div class="row">
                  <div class="4u">

                      <!-- Admin Photo --> 
			            <article class="item">
		                     <a href="#" class="image full"><img src="images/pic03.jpg" alt="Hello!" /></a>
                            <header>
				             <h3 style="padding-left:70px;"><asp:LinkButton ID="AdmOut" runat="server" OnClick="SignOut_Click">Sign Out</asp:LinkButton> </h3>
				            </header>
			            </article>							
                  </div>
                  <div class="8u">

                      <!-- form start -->
                      <div class="row">
                          <div class="4u ap-label">Admin Name:</div>
                          <div class="8u"><asp:Label ID="Lbltxt1" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">Admin ID:</div>
                          <div class="8u"><asp:Label ID="Lbltxt2" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">Designation:</div>
                          <div class="8u"><asp:Label ID="Lbltxt3" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">Email ID:</div>
                          <div class="8u"><asp:Label ID="Lbltxt4" runat="server"></asp:Label></div>
                      </div>
                      <!-- form end -->
                  </div>
              </div>
     
       </div></div>
    </section>

        <!-- Admin Access -->
    <section>
           <header>
		      <h3>Admin | Access</h3>
		   </header>
		<div class="container">  
             
             <!-- Aptitude section -->    
            <div class="row">
                <div class="8u lbl-left">
                   <asp:Label ID="Lblapp" runat="server" Text="Aptitude">
                   </asp:Label>
                   <asp:FileUpload ID="Fileapp" runat="server">
                   </asp:FileUpload>
                </div>
                <div class="4u lbl-left">
                   <asp:Button ID="Button1" runat="server" Text="Save" CssClass="button" OnClick="Btnapp_Click">
                   </asp:Button>
                </div>
            </div>

              <!-- Technical section -->
            <div class="row">
                <div class="8u lbl-left">
                 <asp:Label ID="Lbltech" runat="server" Text="Technical">
                 </asp:Label>
                 <asp:FileUpload ID="Filetech" runat="server">
                 </asp:FileUpload>
                </div>
                <div class="4u lbl-left">
                <asp:Button ID="Btntech" runat="server" Text="Save" CssClass="button" OnClick="Btntech_Click">
                </asp:Button>
                </div>
            </div>
            
             <!-- English Section -->
            <div class="row">
                <div class="8u lbl-left">
                <asp:Label ID="Lblcom" runat="server" Text="CoEnglish">
                </asp:Label>
                <asp:FileUpload ID="Filecom" runat="server">
                </asp:FileUpload>
                </div>
                <div class="4u lbl-left">
                <asp:Button ID="Btncom" runat="server" Text="Save" CssClass="button" OnClick="Btncom_Click">
                </asp:Button>
                </div>
            </div>
    
		</div>
      </section>

      <!-- Admin Access -->
    <section>      
            <div>  
            <span>
           <asp:Button ID="Btncreate" runat="server" Text="Create Assessment" CssClass="button" href="paper.aspx" OnClick="Btncreate_Click">
           </asp:Button>  
              </span>   
              <span>
                <asp:Button ID="btnScore" runat="server" Text="Score" CssClass="button" OnClick="btnScore_Click"></asp:Button>
           </span> 
            </div>      
            <section>
            <div class="tbl-grid">
                <asp:GridView ID="Grdscore" runat="server"></asp:GridView>
            </div></section>
        </section>

            </div>       

    </div>
</asp:Content>
