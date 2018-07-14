package com.imooc;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController//此注解用于启动tomcat
public class HelloController {

    @RequestMapping(value = "/hello",method = RequestMethod.GET)
public String say(){
    return "Hello Spring Boot!";
}
}
