package com.imooc;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/test")
public class TestController {

    /**
     * @馊主意真的可以吗
     */
    @GetMapping("/get1")
    public ResultBean get1(){
        System.out.println("TestController.get1()");
        return new ResultBean("get1 ok");
    }


}
