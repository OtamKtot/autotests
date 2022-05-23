package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Condition.visible;
import static com.codeborne.selenide.Selectors.byXpath;
import static com.codeborne.selenide.Selenide.*;

public class MyTasks {


    SelenideElement createTicket = $("[title=\"Создать заявку на проект\"]"),
            textField = $(".input.input_text"),
            dropDown = $(byXpath("//*[@class='js-input bubbles__input']")),
            dropDown2 = $(byXpath("(//*[@class='js-input bubbles__input'])[2]")),
            firstElementFromDropdown = $(".dd-list__i.selected"),
            dateTimeField = $(byXpath("//*[@class='editor editor_date-time js-dropdown__root ShortDate editor_empty required']")),
            oldDateTime = $(".day.old"),
            newDateTime = $(".day.new", 2),
            createTicket2 = $(byXpath("(//*[text() = 'Создать заявку на проект'])[2]")),
            notificationContainer = $(".notification-body_container"),
            popup = $(".layout__popup-view-content");

    @Step("На боковой навигации выбрать \"Создать заявку на проект\"")
    public MyTasks CreateTicketOnProject() {
        createTicket.click();
        return this;
    }

    @Step("Заполнить обязательные поля и нажать \"Создать заявку на проект\"")
    public MyTasks WriteDescriptionAndCreate() {
        popup.should(visible);
        textField.setValue("TestName");
        dropDown.click();
        firstElementFromDropdown.click();
        dropDown2.click();
        firstElementFromDropdown.click();
        dateTimeField.click();
        oldDateTime.click();
        dateTimeField.click();
        newDateTime.click();
        createTicket2.click();
        return this;
    }

    @Step("На боковой навигации выбрать \"Создать заявку на проект\"")
    public MyTasks OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }
}
