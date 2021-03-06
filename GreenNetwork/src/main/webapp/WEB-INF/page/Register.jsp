<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<script src="jquery/jquery.min.js"></script>
<script src="bootstrap/js/bootstrap.min.js"></script>
<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<script src="js/bootstrapValidator.js"></script>
<link href="css/bootstrapValidator.css" rel="stylesheet" />
</head>
<body>
<div class="container">
  <div class="row">
    <div class="col-lg-8 col-lg-offset-2">
      <div class="page-header">
        <h2>Login</h2>
      </div>
      <form id="defaultForm" method="post" class="form-horizontal" action="ajaxSubmit.php">
        <div class="form-group">
          <label class="col-lg-3 control-label">Username</label>
          <div class="col-lg-5">
            <input type="text" class="form-control" name="username" placeholder="Email"/>
          </div>
        </div>
        
        <div class="form-group">
          <label class="col-lg-3 control-label">Password</label>
          <div class="col-lg-5">
            <input type="password" class="form-control" name="password" placeholder="Password" />
          </div>
        </div>
        
        <div class="form-group">
          <label class="col-lg-3 control-label">Confirm</label>
          <div class="col-lg-5">
            <input type="password" class="form-control" name="confirm" placeholder="Confirm your Password" />
          </div>
        </div>
        
        <div class="form-group">
          <div class="col-lg-5 col-lg-offset-3">
            <button type="submit" class="btn btn-primary btn-block">Sign up</button>
          </div>
        </div>
      </form>
    </div>
  </div>
</div>
<script type="text/javascript">
$(document).ready(function() {
    $('#defaultForm')
        .bootstrapValidator({
            message: 'This value is not valid',
            feedbackIcons: {
                valid: 'glyphicon glyphicon-ok',
                invalid: 'glyphicon glyphicon-remove',
                validating: 'glyphicon glyphicon-refresh'
            },
            fields: {
                username: {
                    message: 'The username is not valid',
                    validators: {
                        notEmpty: {
                            message: 'The username is required and can\'t be empty'
                        },
                        stringLength: {
                            min: 6,
                            max: 30,
                            message: 'The username must be more than 6 and less than 30 characters long'
                        },
                        /*remote: {
                            url: 'remote.php',
                            message: 'The username is not available'
                        },*/
                        regexp: {
                            regexp: /^[a-zA-Z0-9_\.]+$/,
                            message: 'The username can only consist of alphabetical, number, dot and underscore'
                        }
                    }
                },
                password: {
                    validators: {
                        notEmpty: {
                            message: 'The password is required and can\'t be empty'
                        }
                    }
                }
            }
        })

        .on('success.form.bv', function(e) {
            // Prevent form submission
            e.preventDefault();

            // Get the form instance
            var $form = $(e.target);

            // Get the BootstrapValidator instance
            var bv = $form.data('bootstrapValidator');

            // Use Ajax to submit form data
            $.post($form.attr('action'), $form.serialize(), function(result) {
                console.log(result);
            }, 'json');
        });
});
</script>
</body>
</html>