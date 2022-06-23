package ru.comindware.config;

import org.aeonbits.owner.Config;

@Config.Sources("classpath:config/app.properties")
public interface AppConfig extends Config{
    @DefaultValue("https://ppm.36.qa.comindware.net")
    String apiUrl();
    @DefaultValue("https://ppm.36.qa.comindware.net/")
    String baseUrl();
    @DefaultValue("chrome")
    String browser();
    @DefaultValue("101.0")
    String browserVersion();
    @DefaultValue("1920x1080")
    String browserSize();
    String browserMobileView();
    @DefaultValue("http://192.168.0.65:4444/wd/hub")
    String remoteDriverUrl();
    String videoStorage();
}
