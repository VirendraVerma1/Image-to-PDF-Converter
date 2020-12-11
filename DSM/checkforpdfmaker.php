<?php
//this page check if the process is 2 then give all the image name to the computer and it will download and send back to the server

 include("db_con.php");
 
 //$id=$_POST['id'];// i have to detect unmaked pdf id and then process
 
 $proid=2;
 $sql="Select * from DMSdata Where Process='$proid'";
 $run=mysqli_query($con,$sql);

 if(mysqli_num_rows($run) > 0)
 {
   
   $data=mysqli_fetch_assoc($run);
   
   $userid=$data['UserID'];
   $groupid=$data['GroupID'];
   
   $sql="Select * from DMSimagedata Where UserID='$userid' and GroupID = '$groupid'";
   $run=mysqli_query($con,$sql);

         if(mysqli_num_rows($run) > 0)
         {
                 while($data=mysqli_fetch_assoc($run))
                 {
                         echo "".$data['FileName'].";";//TODO you also have to give user id and groupid
                 }
         }
         echo "".$groupid.";";
         echo "".$userid.";";
   
  }
  $con->close(); 
?>