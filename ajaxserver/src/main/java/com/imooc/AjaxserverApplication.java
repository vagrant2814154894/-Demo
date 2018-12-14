package com.imooc;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class AjaxserverApplication {

    public static void main(String[] args) {
        TestController a=new TestController();
        ResultBean a1 = a.get1();
        SpringApplication.run(AjaxserverApplication.class, args);
    }
}
