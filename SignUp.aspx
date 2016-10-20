<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div id="main">
       <section id="contact" class="four">
			<div class="container">
							<header>
								<h2>SignUp</h2>
							</header>
						<!-- Admin Login Section -->
               <div class="allign">
								<div class="6u" >
									<article class="item">      
										<a href="AdminReg.aspx" class="image full"><img src="images/pic03.jpg" alt="Admin" /></a>
										<header>
											<h3><a href="AdminReg.aspx">Admin | Reg</a></h3>
										</header>
									</article>
								</div>
               </div>
                         <!-- Scroll Down Button -->
                              <footer>
								<a href="LogIn.aspx" class="button scrolly">Skip</a>
							  </footer>
                <div>&nbsp;</div>

                        <!-- Candidate Login -->
                <div class="allign">
								<div class="6u" >
									<article class="item">
										<a href="CandidReg.aspx" class="image full"><img src="images/pic03.jpg" alt="Candidate" /></a>
										<header>
											<h3><a href="CandidReg.aspx"> Candidate | Reg </a> </h3>
										</header>
									</article>
								</div>
				</div>
			</div>
    </section>
  </div>
</asp:Content>

