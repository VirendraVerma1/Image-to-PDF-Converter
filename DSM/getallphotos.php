<?php
 include("db_con.php");
 
 $userid=$_POST['id'];
 $groupid=$_POST['groupid'];
 
 $sql="Select * from DMSimagedata where UserID='$userid' and GroupID='$groupid'";
 $run=mysqli_query($con,$sql);

 if($run)
 {
   
   $data=mysqli_fetch_assoc($run);
   //echo "ImageID:".$data['ImageID']."|FileName:".$data['FileName'].";";
     
     
     
   
  }
  $con->close(); 
?>