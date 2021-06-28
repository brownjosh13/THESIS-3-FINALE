<?php
require_once('smsGatewayV4.php');
$token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhZG1pbiIsImlhdCI6MTYyNDM3NTY1OCwiZXhwIjo0MTAyNDQ0ODAwLCJ1aWQiOjg5MjUyLCJyb2xlcyI6WyJST0xFX1VTRVIiXX0.znNmtDXAZEtKYGdUPRjKtYzCuatzmOobhR7Cx7gTfbQ";

$phone_number = "09512248340";
$message = "Test smsGatewayV4";
$deviceID = 124865;
$options = [];

$smsGateway = new SmsGateway($token);
$result = $smsGateway->sendMessageToNumber($phone_number, $message, $deviceID, $options);

print_r($result);
?>
