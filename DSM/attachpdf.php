<?php
     include("db_con.php");
 
     $id=$_POST['id'];
     $pdfcode=$_POST['pdfcode'];
     
     $sql="Select * from DMSdata where UserID='$id' and PDFCode='$pdfcode'";
     $run=mysqli_query($con,$sql);
    
    if($run)
    {
        if(mysqli_num_rows($run) > 0)
        {
            echo "pdf already exist";
        }
        else
        {
            //insert new row
            $sql="Select * from DMSdata where IsSharable=1 and PDFCode='$pdfcode' and Permission=3";
            $run=mysqli_query($con,$sql);
            
            if($run)
            {
                if(mysqli_num_rows($run) > 0)
                {
                    //means user exist
                    //get the user id and group id
                    $data=mysqli_fetch_assoc($run);
                    $parentUser=$data['UserID'];
                    $parentGroupID=$data['GroupID'];
                    $parentfilename=$data['FileName'];
                    
                    $sql="INSERT INTO DMSdata (UserID, GroupID, FileName, PDFCode, Process, Permission, Share, IsSharable, Parent) VALUES ('$id', '$parentGroupID', '$parentfilename', '$pdfcode', 1, 1, 0,0, '$parentUser')";
                    $run=mysqli_query($con,$sql);
                    if($run)
                    {
                        echo "success";
                    }else
                    {
                        echo "server error";
                    }
                    
                }
                else
                {
                    echo "pdf is not sharable";
                }
            }
            else
            {
                echo "server error";
            }
        }
            
    }
     
    $con->close(); 
?>