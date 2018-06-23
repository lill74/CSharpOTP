## CSharpOTP
**Easy otp with cshap**

*Variables*

|Type|Name|Value|
|--|--|--|
|long|time|Time (I recommend unix time)|
|string|key|OTP Key (You can use any string on key variable)|
|long|distance|OTP refesh distance (It depends on what you are using time variable)|

*Functions*
|Type|Name|Args|Function|
|--|--|--|--|
|long|getkey()|bytes[] a|Convert byte array to integer|
|long|generate()|None|Generate OTP key (Initialize variables before using this function)|
|bool|verify()|long hash|Verify both key is same|
|long|generatehash()|string input|Calculate Hash (SHA256)|


 
*Example*

    otp sotp = new otp();
    
    sotp.time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    sotp.key = "wow awesome";
    sotp.distance = 30000;
    
    Console.Write(sotp.generate());

*Contacts*

> Email: a0103932@naver.com

