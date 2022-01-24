<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="add_penalty.aspx.cs" Inherits="ElibraryManagement.librarian.add_penalty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add / Edit Penalty Charges</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
          
                                  <form id="fo1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Add Penalty </label>
                                          <asp:TextBox ID="penalty" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      
                                      
                                      
                                      <div>
                                          
                                          <asp:Button ID="b2" runat="server" class="btn btn-lg btn-info btn-block" Text="Add penalty" OnClick="b2_Click"/>
                                      </div>
                                        
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div>
</asp:Content>
