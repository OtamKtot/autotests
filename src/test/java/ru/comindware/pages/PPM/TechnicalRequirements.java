package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Condition.visible;
import static com.codeborne.selenide.Selenide.*;

public class TechnicalRequirements {

    SelenideElement textField1 = $x("(//*[@class='textarea js-input'])"),
            textField2 = $x("(//*[@class='textarea js-input'])[2]"),
            AddRecordToCollection = $x("(//*[@class='toolbar-btn toolbar-btn_none    toolbar-btn_action  '])[4]"),
            popup = $(".layout__popup-view-content"),
            dropDown = $x("(//*[@class='js-input bubbles__input'])[2]"),
            firstListCheckBox = $x("//*[@class='dd-list__i dd-list__i_checkbox selected']"),
            popupHeader = $x("//*[@class='layout__popup-view-header js-header']"),
            buttonOnAddForm = $x("(//*[@class='toolbar-btn js-btn   btn-strong'])[2]"),
            completeTask = $("[title=\"Завершить задачу\"]"),
            notificationContainer = $(".notification-body_container"),
            loader = $(".loader");

    @Step("Заполнить обязательные поля")
    public TechnicalRequirements WriteDescription(String nameProject) {
        textField1.setValue(nameProject);
        textField2.setValue(nameProject);
        return this;
    }

    @Step("Добавить запись в коллекцию")
    public TechnicalRequirements AddNewRecordToCollection() {
        AddRecordToCollection.click();
        return this;
    }

    @Step("Заполнить поля попапа")
    public TechnicalRequirements FillFieldOnPopup() {
        popup.should(visible);
        dropDown.click();
        firstListCheckBox.click();
        popupHeader.click();
        buttonOnAddForm.click();
        return this;
    }

    @Step("Завершить задачу")
    public TechnicalRequirements CompleteTask() {
        completeTask.click();
        loader.shouldNotBe(visible);
        return this;
    }

    @Step("Задача завершена")
    public TechnicalRequirements OperationComplete() {
        loader.shouldNotBe(visible);
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }

}
