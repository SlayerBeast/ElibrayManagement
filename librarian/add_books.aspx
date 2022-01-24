<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="add_books.aspx.cs" Inherits="ElibraryManagement.librarian.adminBookinventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add New Books</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
          
                                  <form id="fo1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Title</label>
                                          <asp:TextBox ID="bookstitle" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Image</label>
                                          <asp:FileUpload ID="f1" runat="server" class="form-control" />
                                      </div>
                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Books pdf</label>
                                          <asp:FileUpload ID="f2" runat="server" class="form-control" />
                                      </div>
                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Books video</label>
                                          <asp:FileUpload ID="f3" runat="server" class="form-control" />
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Author Name</label>
                                          <asp:TextBox ID="authorname" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Isbn</label>
                                          <asp:TextBox ID="isbn" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Quantity</label>
                                          <asp:TextBox ID="qty" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      
                                      
                                      
                                      
                                      <div>
                                          
                                          <asp:Button ID="b2" runat="server" class="btn btn-lg btn-info btn-block" Text="Add Books" OnClick="b2_Click" />
                                      </div>
                                        <div class="alert alert-success" id="msg" runat="server" style="margin-top:10px; display:none">
                                            <strong>Your Books are Added Successfully</strong>
                                        </div>
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div>
</asp:Content>