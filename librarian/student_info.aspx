<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="student_info.aspx.cs" Inherits="ElibraryManagement.librarian.student_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
                        <h1 class="h3 mb-0 text-gray-800">Students Information</h1>
        </div>
    <div class="container-fluid" style="background-color:white; padding:20px">
    <asp:Repeater ID="r1" runat ="server">
        <HeaderTemplate>
            <table class="table-bordered">
                <tr>
                    <th>Full name</th>
                    <th>Date of Birth</th>
                    <th>Contact Number</th>
                    <th>Email</th>
                    <th>Member id</th>
                    <th>Status</th>
                    <th>Active</th>
                    <th>Deactive</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("full_name") %></td>
                <td><%#Eval("dob") %></td>
                <td><%#Eval("contact_no") %></td>
                <td><%#Eval("email") %></td>
                <td><%#Eval("member_id") %></td>
                <td><%#Eval("approved") %></td>
                <td><a href="student_active.aspx?id=<%# Eval("id") %>">Active</a></td>
                <td><a href="student_deactive.aspx?id=<%# Eval("id") %>">Deactive</a></td>
             
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </div>
</asp:Content>
