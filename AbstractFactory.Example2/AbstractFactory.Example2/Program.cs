using AbstractFactory.Example2.Factories;
using AbstractFactory.Example2;


IPaymentGatewayFactory paymentGatewayFactory = new PayPalGatewayFactory();

// inyectar la fabrica al servicio de pago
PaymentService paymentService = new PaymentService(paymentGatewayFactory);

decimal valor = 1080;
paymentService.ProcesoDePago(valor);

// si quisieramos cambiar al provvedor  , simplemente cambiamos la fabrica
IPaymentGatewayFactory paymentGatewayFactory1 = new StripeGatewayFactory();
PaymentService paymentService1 = new PaymentService(paymentGatewayFactory1);

decimal valor2 = 1233;
paymentService1.ProcesoDePago(valor2);