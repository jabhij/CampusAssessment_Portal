<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="main">

        <!-- Introduction Part -->
        <section id="top" class="one">
            <div>
			   <a href="#" class="image featured"><img src="images/banner.jpg" alt=""/></a>
            </div>
			<div class="container">
				<header>
			  	   <p class="alt">This website is all about<strong> Online Assessment</strong> conducted by <strong><a href="http://www.contata.com/" target="_blank">Contata Solutions</a></strong>, it will take you deeper in 
							the ocean of skill testing in Apptitude, Logical reasoning and Comprehensive English along with your Core Technical Domain, that includes Languages (.NET, JAVA, C, C++ etc.), 
                             Subjects (Networking, Database, Data Structure etc.). So buckle up for the challanges...
                      <a href="#">Explore Assessments here.</a>
			  	   </p>
				</header>												
			    <footer>
					<a href="#Explore Assessments" class="button scrolly">Skip</a>
				</footer>
			</div>
		</section>

        <!-- Content Section -->
        <section id="Explore Assessments" class="two">
			<div class="container">			
			   <header>
					<h2>Explore Assessments</h2>
	   		   </header>		
			<div class="row">
				<div class="4u">
					<article class="item">
						<a href="Apptitude.htm" class="image full" target="_blank"><img src="images/Quantative-icon.png" alt="Test Your Brain!" /></a>
   					      <header>
							<h3>Quantative</h3>
						  </header>
					</article>		
				</div>
				<div class="4u">
					<article class="item">
						<a href="Technical.html" class="image full" target="_blank"><img src="images/Technical-icon.png" alt="Test Your Brain!" /></a>
							<header>
							   <h3>Technical</h3>
							</header>
					</article>			
				</div>
				<div class="4u">
					<article class="item">
						<a href="English.html" class="image full" target="_blank"><img src="images/English-icon.png" alt="Test Your Brain!" /></a>
							<header>
								<h3>English</h3>
							</header>
					</article>
				</div>
			</div>
                            <footer>
								<a href="#Register" class="button scrolly">Skip</a>
							</footer>
			</div>
		</section>

        <!-- Registeration Section -->
    <!--    <section id="Register" class="three">
			<div class="container">
				<header>
				    <h2>Sign In / Sign Up</h2>
				</header>            
				<div class="button">                                    
                  <a href="LogIn.aspx">Sign In </a>                 
				</div>	
                <p>(Click here, If you are Already Registered!)</p>					
				<div class="button">                                    
                  <a href="SignUp.aspx">Sign Up </a>                   
				</div>	
                <p>(Register here!)</p>
                              <footer>
								<a href="#contact" class="button scrolly">Skip</a>
							  </footer>
			</div>
		</section> -->

       <div class="container">
        <div id="disqus_thread"></div>
    <script type="text/javascript">
        
        var disqus_shortname = 'jaiswalabhishekblogspotin';  
 
        (function () {
            var dsq = document.createElement('script'); dsq.type = 'text/javascript'; dsq.async = true;
            dsq.src = '//' + disqus_shortname + '.disqus.com/embed.js';
            (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(dsq);
        })();
    </script>
    <noscript>Please enable JavaScript to view the <a href="http://disqus.com/?ref_noscript">comments powered by Disqus.</a></noscript>
    <a href="http://disqus.com" class="dsq-brlink">comments powered by <span class="logo-disqus">Disqus</span></a>
    
        </div>

        <!-- Contact Form -->
        <section id="contact" class="four">
			<div class="container container1">
				<header>
					<h2>Contact</h2>
				</header>
				<p>For any query, please contact us. We are here to help you!</p>							
				<form method="post" action="#">
					<div class="row half">
						<div class="6u">
                            <input type="text" class="text" name="name" placeholder="Name"/>
						</div>
						<div class="6u">
                            <input type="text" class="text" name="email" placeholder="Email"/>
						</div>
					</div>
					<div class="row half">
						<div class="12u">
							<textarea name="message" placeholder="Message"></textarea>
						</div>
					</div>
					<div class="row">
						<div class="12u">
							<asp:Button ID="BtnSub" runat="server" Text="Send" CssClass="button" ></asp:Button>
						</div>
					</div>
				</form>
			</div>
		</section>
    </div>
    
    <div class="container">
    <script type="text/javascript">
        
        var disqus_shortname = 'jaiswalabhishekblogspotin';  
      
        (function () {
            var s = document.createElement('script'); s.async = true;
            s.type = 'text/javascript';
            s.src = '//' + disqus_shortname + '.disqus.com/count.js';
            var a = alert('');
            (document.getElementsByTagName('HEAD')[0] || document.getElementsByTagName('BODY')[0]).appendChild(s);
        } ());
    </script>
    </div>
</asp:Content>
