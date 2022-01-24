<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ElibraryManagement.librarian.login" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Library Management System</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet">

</head>

<body class="bg-gradient-primary">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="text-center" >
                                        <img class="img-fluid px-3 px-sm-4 mt-3 mb-4" style="width: 20rem;"
                                            src="img/admin.png" alt="">
                                    </div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Admin Login</h1>
                                    </div>
                                    <form id="f1" runat="server">
                                        <div class="form-group">
                                            <asp:TextBox ID="username" runat="server" class="form-control" placeholder="username"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="password" runat="server" class="form-control" placeholder="password" TextMode="Password"></asp:TextBox>
                                        </div>
                                       
                                       <asp:Button ID="b1" runat="server" Text="Sign in" class="btn btn-primary btn-user btn-block" OnClick="b1_Click"></asp:Button>

                                        <hr>
                                        <div class="alert alert-danger" id="error" runat="server" style="margin-top:10px; display:none">
                                            <strong>You have entered wrong username or password.</strong>
                                        </div>
                                    </form>
                                    <hr>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="js/sb-admin-2.min.js"></script>

</body>

</html>