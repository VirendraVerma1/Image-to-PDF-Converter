<?php
        include("db_con.php");
        
        $userid=$_POST['id'];
        $groupid=$_POST['groupId'];
        $imageid=$_POST['imageId'];
        $imageorder=$_POST['imageorder'];
        
        
        
        $date=date("Y-m-d h:i:s");
        
        if(isset($_FILES['theFile']))
        {   
         
         $file = $_FILES['theFile']['name'];
         $file_loc = $_FILES['theFile']['tmp_name'];
         $folder = "upload/".$file;
         
         $newfilename=$userid.$groupid.$imageid.".jpg";
         
         
                 if(move_uploaded_file($file_loc,$folder))
                 {
                    rename($folder,"upload/".$newfilename);     
                 
                  $sql="INSERT INTO DMSimagedata (UserID,GroupID,ImageID,ImageOrder,FileName,Date) VALUES('$userid','$groupid','$imageid','$imageorder','$newfilename','$date')";
                  $run=mysqli_query($con,$sql);
                  if($run){
                 
                  echo "success";
                  
                  }else{
                      if (!$con -> query("INSERT INTO DMSimagedata (UserID,GroupID,ImageID,ImageOrder,FileName,Date) VALUES('$userid','$groupid','$imageid','$imageorder','$newfilename','$date')")) {
                          echo("Error description: " . $con -> error);
                        }
                  
                  }
                  $sql="SELECT * FROM DMSdata WHERE UserID='$userid' and GroupID='$groupid'";
                  $run=mysqli_query($con,$sql);
                  if($run)
                  {
                          if(mysqli_num_rows($run) > 0)
                               {
                                       //exist
                               }else{
                                   //not their
                                   //create one
                                   $filename="file";
                                   $pdfcode=$userid."".$groupid;//TODO generate unique number
                                   $process=1;
                                   $sql="INSERT INTO DMSdata(UserID,GroupID,FileName,Date,PDFCode,Process) VALUES('$userid','$groupid','$filename','$date','$pdfcode','$process')";
                                  mysqli_query($con,$sql);
                                  echo "Inserted to data";
                               }
                  }
                        
                  
                 }
                 else
                 {
                  
                  echo "Error.Please try again";
                                
                  }
         }
        
        $con->close(); 
?>