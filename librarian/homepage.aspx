<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ElibraryManagement.librarian.demo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class ="breadcrumb">
        <div class="col-sm-4">
            <div class="page-header-float-left">
                <div class="page-title">
                    <h1>Dashboard</h1>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid" style="min-height=500px; background-color:white">
    </div>
     <div class="row">
          <!-- Left col -->
          <section class="col-lg-12 connectedSortable">
            <!-- Custom tabs (Charts with tabs)-->
            <div class="card">
              <div class="card-header">
                <h3 class="card-title">
                  <i class="fas fa-hand"></i>
                  Hello Admin!
                </h3>
                <div class="card-tools">
                  <img class="img-fluid px-5 px-sm-6 mt-3 mb-4" style="width: 600px;" content-align:"center"; 
                        src="img/librairy.jpg" alt="">
                </div>
                  <div>
                      <h5>Welcome India's Most efficient and Developed E- Librairy Management System</h5>
                      <p>eLibrary is one of the largest and most comprehensive repository of over 3200+ titles for learners across disciplines. From Business & Economics to Humanities to Engineering and competitive exams preparation, eLibrary has it all.</p>
                  </div>
              </div><!-- /.card-header -->
             
            </div>
              </section>
      
</asp:Content>
