using System;
using System.Collections.Generic;
using FhirCore.Base;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;

namespace ResourceTypeServices.R5
{
    /// <summary>
    /// FHIR R5 List �귽
    /// 
    /// <para>
    /// List �귽�Ω�޲z�@�լ������ت����X�C���i�H��ܦU���������C��A
    /// �p�Ī��M��B���D�M��B�L�ӲM�浥�CR5 �������ѤF�W�j���\��M��n�����ާ@�ʡC
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var list = new List("list-001")
    /// {
    ///     Status = new FhirCode("current"),
    ///     Mode = new FhirCode("working"),
    ///     Title = new FhirString("Patient Medications"),
    ///     Date = new FhirDateTime(DateTime.Now)
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 ������ List �귽�㦳�H�U�S�I�G
    /// - �W�j����Ƶ��c
    /// - ��i�����ҳW�h  
    /// - ��n�����ާ@��
    /// - �䴩��������C��޲z
    /// </para>
    /// 
    /// <para>
    /// �ϥγ����G
    /// - �Ī��M��޲z
    /// - ���D�M��l��
    /// - �L�ӥv�O��
    /// - �v���p������
    /// </para>
    /// </remarks>
    public class List : ResourceBase
    {
        private FhirCode? _status;
        private FhirCode? _mode;
        private FhirString? _title;
        private FhirDateTime? _date;
        private FhirBoolean? _deleted;

        /// <summary>
        /// �귽����
        /// </summary>
        /// <value>�T�w�� "List"</value>
        public override string ResourceType => "List";

        /// <summary>
        /// ���o FHIR ����
        /// </summary>
        /// <returns>R5 ������ "5.0.0"</returns>
        public override string GetFhirVersion() => "5.0.0";

        /// <summary>
        /// �M�檬�A
        /// 
        /// <para>
        /// ���ܲM�檺�ثe���A�C�o���T�w�M��O�_���̷s�B�i�ΫD�`���n�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Status = new FhirCode("current");  // �ثe����
        /// list.Status = new FhirCode("retired");  // �w����
        /// list.Status = new FhirCode("entered-in-error");  // ���~��J
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �i�઺�ȥ]�A�G
        /// - current: �M��ثe���ĥB�̷s
        /// - retired: �M��w���A�ϥ�
        /// - entered-in-error: �M��O���~�إߪ�
        /// </para>
        /// 
        /// <para>
        /// ���A�ܧ������ԷV�B�z�A�åB�n���A���f�ְO���C
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        /// <summary>
        /// �M��Ҧ�
        /// 
        /// <para>
        /// ���ܲM�檺�����M�γ~�C�o�M�w�F�M��p��Q�����M�ϥΡC
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Mode = new FhirCode("working");    // �u�@�M��
        /// list.Mode = new FhirCode("snapshot");   // �ַӲM��
        /// list.Mode = new FhirCode("changes");    // �ܧ�M��
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �D�n�Ҧ��]�A�G
        /// - working: �u�@�M��A�i��|�ܧ�
        /// - snapshot: �S�w�ɶ��I���ַ�
        /// - changes: �O���ܧ󪺲M��
        /// </para>
        /// 
        /// <para>
        /// �Ҧ���ܼv�T�M�檺�����M�B�z�覡�C
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }

        /// <summary>
        /// �M����D
        /// 
        /// <para>
        /// �M�檺�y�z�ʼ��D�A�Ω��ѧO�M�y�z�M�檺�ت��C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Title = new FhirString("Patient Active Medications");
        /// list.Title = new FhirString("Known Allergies");
        /// list.Title = new FhirString("Current Problems");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���D���ӡG
        /// - �M���y�z�M�檺���e
        /// - �K��ϥΪ̲z��
        /// - �A�X�b�ϥΪ̤��������
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        /// <summary>
        /// �M��إߩγ̫��s���
        /// 
        /// <para>
        /// �O���M��إߩγ̫�@���ק諸����M�ɶ��C
        /// �o���l�ܲM�檺�ɮĩʫܭ��n�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Date = new FhirDateTime(DateTime.Now);
        /// list.Date = new FhirDateTime("2024-01-15T10:30:00Z");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ����Ω�G
        /// - �l�ܲM�檺�ɮĩ�
        /// - ��������M�f��
        /// - �T�w�M�檺������
        /// </para>
        /// 
        /// <para>
        /// ��ĳ�ϥ� ISO 8601 �榡������ɶ��C
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        /// <summary>
        /// �O�_�w�R���аO
        /// 
        /// <para>
        /// ���ܲM��O�_�w�Q�аO���R���C�o�O�@�سn�R������A
        /// ���\�O�d���v�O�����P�ɼаO�M�欰���i�ΡC
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Deleted = new FhirBoolean(false);  // ���R��
        /// list.Deleted = new FhirBoolean(true);   // �w�R��
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �R���аO���γ~�G
        /// - �n�R������
        /// - �O�d�f�֭y��
        /// - �קK�w�R���a�Ӫ���ƿ�
        /// </para>
        /// 
        /// <para>
        /// �w�R�����M��q�`�����Ӧb���`�d�ߤ���^�C
        /// </para>
        /// </remarks>
        public FhirBoolean? Deleted
        {
            get => _deleted;
            set
            {
                _deleted = value;
                OnPropertyChanged(nameof(Deleted));
            }
        }

        /// <summary>
        /// ��l�� List ���O���s�������
        /// </summary>
        public List() : base()
        {
        }

        /// <summary>
        /// �ϥΫ��w�� ID ��l�� List ���O���s�������
        /// </summary>
        /// <param name="id">�M�檺�ߤ@�ѧO�X</param>
        /// <exception cref="ArgumentException">�� ID ���ũ� null ���Y�X</exception>
        public List(string id) : this()
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID ���ର��", nameof(id));
            
            Id = id;
        }

        /// <summary>
        /// ���� R5 �S�w������
        /// </summary>
        /// <returns>���ҵ��G�A�p�G���ҥ��ѫh�]�t���~�T��</returns>
        /// <remarks>
        /// <para>
        /// R5 ���������ҳW�h�G
        /// - Status �����O���ĭ�
        /// - Mode �����O���ĭ�
        /// - Date ����O���Ӥ���]�p�G�O snapshot �Ҧ��^
        /// - Title �b�Y�ǼҦ��U�O���ݪ�
        /// </para>
        /// </remarks>
        protected override System.ComponentModel.DataAnnotations.ValidationResult? ValidateVersionSpecific()
        {
            // ���� Status
            if (Status == null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "List.Status �O���ݪ�");
            }

            // ���� Mode
            if (Mode == null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "List.Mode �O���ݪ�");
            }

            // ���Ҥ���޿�
            if (Date?.Value != null && Mode?.Value == "snapshot")
            {
                if (Date.Value > DateTime.Now)
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        "Snapshot �Ҧ����M��������O���Ӯɶ�");
                }
            }

            return null;
        }

        /// <summary>
        /// �إ߲M�檺�r����
        /// </summary>
        /// <returns>�]�t�M��D�n��T���r��</returns>
        public override string ToString()
        {
            var title = Title?.Value ?? "Untitled List";
            var status = Status?.Value ?? "Unknown";
            var mode = Mode?.Value ?? "Unknown";
            
            return $"List(Id: {Id}, Title: {title}, Status: {status}, Mode: {mode})";
        }
    }
}
