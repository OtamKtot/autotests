package ru.comindware.tests.PPM.data;

import ru.comindware.API.AccountService;
import ru.comindware.utils.DateAndTimeUtils;

import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;

public class RequestProjectData {
    DateAndTimeUtils dateAndTimeUtils = new DateAndTimeUtils();
    AccountService accountService = new AccountService();

    public Map<String, String> setObjectData(String loginAdmin, String passwordAdmin, String nameProject, String accountName) {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);
        String accountId = accountService.GetByAccountName(loginAdmin, passwordAdmin, accountName);
        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", accountName);
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", accountId);
        return objectData;
    }

    public Map<String, String> setRateUrgencyData() {
        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.162", "true");
        return objectData;
    }

    public Map<String, String> setProjectData(String requestProjectId) {
        Map<String, String> objectData = new HashMap<>();
        objectData.put("ProjectRequest", requestProjectId);
        objectData.put("Type", "879022");
        return objectData;
    }

    public Map<String, String> setEstablishProjectData(String loginAdmin, String passwordAdmin, String nameProject, String codeProject, String directorName, String requestProjectId) {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);
        String accountId = accountService.GetByAccountName(loginAdmin, passwordAdmin, directorName);
        Map<String, String> objectData = new HashMap<>();
        objectData.put("ProjectRequest", requestProjectId);
        objectData.put("Code", codeProject);
        objectData.put("Name", nameProject);
        objectData.put("Director", accountId);
        objectData.put("PlannedStartDate", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("PlannedEndDate", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("Isp_ED", "true");
        objectData.put("Status", "22");
        return objectData;
    }
}
