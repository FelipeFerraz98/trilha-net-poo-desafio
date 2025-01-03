using DesafioPOO.Models;


Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);

nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("987654321", "Iphone X", "98765443218765", 128);

iphone.InstalarAplicativo("Spotify");

iphone.Ligar();
iphone.ReceberLigacao();