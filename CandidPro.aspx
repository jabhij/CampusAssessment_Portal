<%@ Page Title="" Language="C#" MasterPageFile="~/CandidPro.master" AutoEventWireup="true" CodeFile="CandidPro.aspx.cs" Inherits="CandidPro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="main">
       <section id="contact" class="four">
            <header>
	    	 <h3>Candidate | Profile</h3>
		    </header>
	    <div class="container">

          <!-- Admin Description -->
          <div class="admin-profile">

              <div class="row">
                  <div class="4u">

                      <!-- Candidate Photo --> 
			            <article class="item">
		                     <a href="#" class="image full"><img src="images/pic03.jpg" alt="Hello!" /></a>
                            <header>
				             <h3 style="padding-left:70px;"> <asp:LinkButton ID="CanOut" runat="server" OnClick="SignOut_Click">Sign Out</asp:LinkButton></h3>
				            </header>
			            </article>							
                  </div>
                  <div class="8u">

                      <!-- form start -->
                      <div class="row">
                          <div class="4u ap-label">Name:</div>
                          <div class="8u"><asp:Label ID="Lbltxt1" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">Roll No:</div>
                          <div class="8u"><asp:Label ID="Lbltxt2" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">JEE Rank:</div>
                          <div class="8u"><asp:Label ID="Lbltxt3" runat="server"></asp:Label></div>
                      </div>
                      <div class="row">
                          <div class="4u ap-label">Institute:</div>
                          <div class="8u"><asp:Label ID="Lbltxt4" runat="server"></asp:Label></div>
                      </div>
                      <!-- form end -->
                  </div>
              </div>
     
       </div></div>
    </section>

    <!-- Candidate Exam Access Section -->
     <section>
         <header>
               <h3>Candidate | Access</h3>
         </header>
	   <div class="container">
           <div>
              <asp:Button ID="Btnassessment" runat="server" Text="Give Assessment" CssClass="button" OnClick="Btnassessment_Click"></asp:Button>
           </div>     
	   </div>
     </section>
   
   </div>
</asp:Content>

