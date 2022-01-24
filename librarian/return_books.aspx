<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="return_books.aspx.cs" Inherits="ElibraryManagement.librarian.return_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
      <div class ="breadcrumb">
        <div class="col-sm-4">
            <div class="page-header-float-left">
                <div class="page-title">
                    <h1>Return Books </h1>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid" style="min-height=500px; background-color:white">
        <br /><br />
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table class="table table-bordered">
                    <tr>
                        <th>member_id</th>
                        <th>books_isbn</th>
                        <th>books_issue_date</th>
                        <th>books_approx_return_date</th>
                        <th>full_name</th>
                        <th>is_books_return</th>
                        <th>books_returned_date</th>
                        <th>latedays</th>
                        <th>penalty</th>
                        <th>Return Books</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("member_id") %></td>
                    <td><%#Eval("books_isbn") %></td>
                    <td><%#Eval("books_issue_date") %></td>
                    <td><%#Eval("books_approx_return_date") %></td>
                    <td><%#Eval("full_name") %></td>
                    <td><%#Eval("is_books_return") %></td>
                    <td><%#Eval("books_returned_date") %></td>
                    <td><%#Eval("latedays") %></td>
                    <td><%#Eval("penalty") %></td>
                    <td><a href="returnbook.aspx?id=<%#Eval("id") %>">Return Book</a></td>
                </tr>

            </ItemTemplate>
            <FooterTemplate>
                </table>

            </FooterTemplate>
        </asp:DataList>
        
    </div>
</asp:Content>
